using Kursach.Entites;
using Kursach.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Kursach.Controllers;


namespace Kursach
{
    public partial class PlayForm : Form
    {
        const int playerSpeedX = 10;
        const int playerSpeedY = 10;

        public Image dwarfSheet;
        public Image gladiatorSheet;
        public Hero player;
        public Gladiator gladiator;
        public PlayForm()
        {
            InitializeComponent();

            timer1.Interval = 41;
            timer1.Tick += new EventHandler(Update);

            KeyDown += new KeyEventHandler(OnPress);
            KeyUp += new KeyEventHandler(OnKeyUp);

            Init();
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                player.spaceIsUp = true;
            if (player.spaceIsUp == true && player.isAttack == true)
            {
                player.isAttack = false;
                player.spaceIsUp = false;
                if (player.dirX != 0 || player.dirY != 0)
                {
                    if (player.flip == 1)
                    {
                        player.SetAnimationConfiguration(1);
                        player.isLeft = false;
                        player.isRight = true;
                    }
                    else
                    {
                        player.SetAnimationConfiguration(6);
                        player.isLeft = true;
                        player.isRight = false;
                    }
                }
                else
                {
                    if (player.flip == 1)
                    {
                        player.SetAnimationConfiguration(0);
                        player.isLeft = false;
                        player.isRight = false;
                    }
                    else
                    {
                        player.SetAnimationConfiguration(5);
                        player.isLeft = false;
                        player.isRight = false;
                    }
                }
            }
            if (e.KeyCode == Keys.D && player.isRight)
                player.dirX = 0;
            if (e.KeyCode == Keys.A && player.isLeft)
                player.dirX = 0;
            if (e.KeyCode == Keys.W && player.isTop)
                player.dirY = 0;
            if (e.KeyCode == Keys.S && player.isBottom)
                player.dirY = 0;

            if (player.dirX == 0 && player.dirY == 0 && player.isAttack == false)
            {
                player.isMoving = false;
                if (player.flip == 1)
                    player.SetAnimationConfiguration(0);
                else player.SetAnimationConfiguration(5);
            }
        }

        public void OnPress(object sender, KeyEventArgs e)
        {
            if (player.isAttack)
                switch(e.KeyCode)
                {
                    case Keys.A:
                        player.SetAnimationConfiguration(7);
                        player.flip = -1;
                        player.dirX = -playerSpeedX;
                        player.isMoving = true;
                        player.isLeft = true;
                        player.isRight = false;
                        break;
                    case Keys.D:
                        player.SetAnimationConfiguration(2);
                        player.flip = 1;
                        player.dirX = playerSpeedX;
                        player.isMoving = true;
                        player.isLeft = false;
                        player.isRight = true;
                        break;
                    case Keys.W:
                        player.dirY = -playerSpeedY;
                        player.isMoving = true;
                        player.isBottom = false;
                        player.isTop = true;
                        break;
                    case Keys.S:
                        player.dirY = playerSpeedY;
                        player.isMoving = true;
                        player.isBottom = true;
                        player.isTop = false;
                        break;
                }
            else
            switch (e.KeyCode)
            {
                case Keys.W:
                    player.dirY = -playerSpeedY;
                    player.isMoving = true;
                    player.isBottom = false;
                    player.isTop = true;
                    if (player.flip == 1)
                        player.SetAnimationConfiguration(1);
                    else player.SetAnimationConfiguration(6);
                    break;
                case Keys.S:
                    player.dirY = playerSpeedY;
                    player.isMoving = true;
                    player.isBottom = true;
                    player.isTop = false;
                    if (player.flip == 1)
                        player.SetAnimationConfiguration(1);
                    else player.SetAnimationConfiguration(6);
                    break;
                case Keys.A:
                    player.dirX = -playerSpeedX;
                    player.isMoving = true;
                    player.isLeft = true;
                    player.isRight = false;
                    player.SetAnimationConfiguration(6);
                    player.flip = -1;
                    break;
                case Keys.D:
                    player.dirX = playerSpeedX;
                    player.isMoving = true;
                    player.isLeft = false;
                    player.isRight = true;
                    player.SetAnimationConfiguration(1);
                    player.flip = 1;
                    break;
            }
            switch (e.KeyCode)
            {
                case Keys.Space:
                    player.isAttack = true;
                    player.attackIsOver = true;
                    player.spaceIsUp = false;
                    if (player.flip == 1)
                        player.SetAnimationConfiguration(2);
                    else player.SetAnimationConfiguration(7);
                    break;
                case Keys.Escape:
                    Application.Exit();
                    break;
            }
        }

        public void Init()
        {
            dwarfSheet = new Bitmap(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Sprites\Dwarf.png");
            gladiatorSheet = new Bitmap(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Sprites\Gladiator.png");

            player = new Hero(500, 500, dwarfSheet);
            gladiator = new Gladiator(300, 300, gladiatorSheet);
            timer1.Start();
        }

        public void Update(object sender, EventArgs e)
        {
            if (player.isAttack)
                if (PhysicsController.isAttack(player, gladiator))
                {
                    gladiator.isUnderAttack = true;
                    gladiator.hitPoints -= player.powerOfAttack;
                    if (gladiator.hitPoints == 0)
                    {
                        if (gladiator.flip == 1)
                            gladiator.SetAnimationConfiguration(4);
                        else gladiator.SetAnimationConfiguration(9);
                    }
                }
            if (PhysicsController.isCollide(player, gladiator))
            {
                player.posX = 960;
                player.posY = 540;
            }
            if (player.isMoving)
                player.Move(PhysicsController.isOutOfMap(player));
            gladiator.changeDirection(player);
            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            gladiator.PlayAnimation(g);
            if (player.isAttack && player.spaceIsUp)
                player.PlayAttack(g);
            else 
            player.PlayAnimation(g);
        }

        private void PlayForm_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {

        }

        private void PlayForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

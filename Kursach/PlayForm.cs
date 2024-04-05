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
        PauseForm pauseForm;
        EndGameForm endGameForm;
        public bool isPause;

        public string playerName;
        public int playerScore;

        const int playerSpeedX = 10;
        const int playerSpeedY = 10;

        public Image dwarfSheet;
        public Image gladiatorSheet;
        public Image HpImage;

        public Hero player;
        public List<Gladiator> gladiators = new List<Gladiator>();

        Random rnd;

        public PlayForm(string playerName)
        {
            InitializeComponent();

            pauseForm = new PauseForm();
            pauseForm.Owner = this;
            isPause = false;
            this.playerName = playerName;
            playerScore = 0;
            rnd = new Random();
            endGameForm = null;

            timer1.Interval = 41;
            timer1.Tick += new EventHandler(Update);

            timer2.Interval = 2000;
            timer2.Tick += new EventHandler(UpdateEnemy);

            KeyDown += new KeyEventHandler(OnPress);
            KeyUp += new KeyEventHandler(OnKeyUp);

            Init();
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (player.isFinal == true)
                return;
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
            if (player.isFinal == true)
                return;
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
                    isPause = true;
                    this.Hide();
                    pauseForm.ShowDialog();
                    break;
            }
        }

        public void Init()
        {
            dwarfSheet = new Bitmap(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Sprites\Dwarf.png");
            gladiatorSheet = new Bitmap(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Sprites\Gladiator.png");
            HpImage = new Bitmap(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Sprites\Heart1.png");

            player = new Hero(500, 500, dwarfSheet);
            timer1.Start();
            timer2.Start();
        }

        public void Update(object sender, EventArgs e)
        {
            if (isPause || endGameForm != null)
                return;
            foreach (Gladiator gladiator in gladiators.ToList())
                if (gladiator.animationDeathIsOver == true)
                {
                    gladiators.Remove(gladiator);
                    playerScore += 1;
                    this.button1.Text = playerScore.ToString();
                }
            if (player.isAttack)
                foreach(Gladiator gladiator in gladiators)
                    if (PhysicsController.isAttack(player, gladiator))
                    {
                        gladiator.isUnderAttack = true;
                        gladiator.hitPoints -= player.powerOfAttack;
                        if (gladiator.hitPoints == 0)
                        {
                            if (gladiator.flip == 1)
                                gladiator.SetAnimationConfiguration(4);
                            else gladiator.SetAnimationConfiguration(9);
                            gladiator.currentFrame = 0;
                        }
                    }
            foreach (Gladiator gladiator in gladiators)
            {
                if (PhysicsController.isCollide(player, gladiator) && player.isFinal == false)
                {
                    if (player.posX > gladiator.posX)
                        player.posX += 150;
                    else player.posX -= 150;
                    player.hitPoints -= 1;
                    player.isUnderAttack = true;
                    if (player.hitPoints == 0)
                    {
                        timer1.Interval = 150;
                        player.isFinal = true;
                        if (player.flip == 1)
                            player.SetAnimationConfiguration(4);
                        else player.SetAnimationConfiguration(9);
                        player.currentFrame = 0;
                    }
                }
                gladiator.changeDirection(player);
            }
            if (player.isFinal == true && player.animationDeathIsOver == true)
            {
                Records.saveScore(playerName, playerScore);
                pauseForm.Close();
                this.Hide();
                endGameForm = new EndGameForm(playerScore);
                endGameForm.Owner = this;
                endGameForm.Show();
            }

            if (player.isMoving)
                player.Move(PhysicsController.isOutOfMap(player));
            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach(Gladiator gladiator in gladiators)
                gladiator.PlayAnimation(g);
            if (player.isAttack && player.spaceIsUp)
                player.PlayAttack(g);
            else 
            player.PlayAnimation(g);
            if (player.hitPoints == 3)
            {
                g.DrawImage(HpImage, 1600, 50, 80, 80);
                g.DrawImage(HpImage, 1680, 50, 80, 80);
                g.DrawImage(HpImage, 1760, 50, 80, 80);
            }
            else if (player.hitPoints == 2)
            {
                g.DrawImage(HpImage, 1680, 50, 80, 80);
                g.DrawImage(HpImage, 1760, 50, 80, 80);
            }
            else
            {
                g.DrawImage(HpImage, 1680, 50, 80, 80);
            }
        }

        public void UpdateEnemy(object sender, EventArgs e)
        {
            if (isPause)
                return;
            int value1, value2;
            value1 = rnd.Next(-200, 2100);
            if (value1 > -50 || value1 < 2000)
            {
                int r = rnd.Next(0, 2);
                if (r == 0)
                    value2 = rnd.Next(-200, -100);
                else
                    value2 = rnd.Next(1100, 1200);
            }
            else value2 = rnd.Next(0, 1080);
            gladiators.Add(new Gladiator(value1, value2, gladiatorSheet));
            if (playerScore % 5 == 0 && timer2.Interval > 200)
                timer2.Interval -= 50;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

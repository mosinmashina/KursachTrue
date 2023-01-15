using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursach.Entites;
using System.Drawing;

namespace Kursach.Models
{
    public class Gladiator : Entity
    {

        public Gladiator()
        {

        }

        public Gladiator(int posX, int posY, Image spriteSheet) : base(posX, posY, spriteSheet)
        {
            size = 31;
            idleFrames = 5;
            runFrames = 8;
            attackFrames = 7;
            deathFrames = 7;
            currentLimit = idleFrames;
            playerModelSize = new Size(150, 150);
            hitPoints = 3;
            spriteSheetUnderAttack = new Bitmap(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Sprites\GladiatorUnderAttack.png");
        }

        public override void Move(int howMove)
        {
            switch (howMove)
            {
                case 0:
                    posX += dirX;
                    posY += dirY;
                    break;
                case 1:
                    posY += dirY;
                    break;
                case 2:
                    posX += dirX;
                    break;
            }
        }

        public void changeDirection(Hero player)
        {
            if (currentAnimation == 4 || currentAnimation == 9)
                return;
            if (player.posX > posX)
            {
                dirX = 5;
                flip = 1;
                SetAnimationConfiguration(1);
            }
            else if (player.posX < posX)
            {
                dirX = -5;
                flip = -1;
                SetAnimationConfiguration(6);
            }
            else dirX = 0;
            if (player.posY > posY)
                dirY = 5;
            else if (player.posY < posY)
                dirY = -5;
            else dirY = 0;
            Move(0);
        }

        public override void SetAnimationConfiguration(int currentAnimation)
        {
            this.currentAnimation = currentAnimation;
            switch (currentAnimation)
            {
                case 0:
                    currentLimit = idleFrames;
                    break;
                case 1:
                    currentLimit = runFrames;
                    break;
                case 2:
                    currentLimit = runFrames;
                    break;
                case 3:
                    break;
                case 4:
                    currentLimit = deathFrames;
                    break;
                case 5:
                    currentLimit = idleFrames;
                    break;
                case 6:
                    currentLimit = runFrames;
                    break;
                case 7:
                    currentLimit = attackFrames;
                    break;
                case 8:
                    break;
                case 9:
                    currentLimit = deathFrames;
                    break;

            }
        }

        public override void PlayAnimation(Graphics g)
        {
            if (currentAnimation == 4 || currentAnimation == 9)
            {
                if (currentFrame < currentLimit - 1)
                    currentFrame++;
                else currentFrame = 0;
                if (currentFrame == 0)
                    animationDeathIsOver = true;
                if (!animationDeathIsOver)
                    g.DrawImage(spriteSheet, new Rectangle(new Point(posX, posY), playerModelSize),
                    32f * currentFrame, 32 * currentAnimation, size, size, GraphicsUnit.Pixel);
                return;
            }
            if (currentFrame < currentLimit - 1)
                currentFrame++;
            else currentFrame = 0;
            if (!isUnderAttack)
                g.DrawImage(spriteSheet, new Rectangle(new Point(posX, posY), playerModelSize),
                    32f * currentFrame, 32 * currentAnimation, size, size, GraphicsUnit.Pixel);
            else
            {
                g.DrawImage(spriteSheetUnderAttack, new Rectangle(new Point(posX, posY), playerModelSize),
                    32f * currentFrame, 32 * currentAnimation, size, size, GraphicsUnit.Pixel);
                isUnderAttack = false;
            }
            //Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
            //g.DrawRectangle(blackPen, new Rectangle(new Point(posX + 22, posY + 30), new Size((int)(playerModelSize.Width/1.5), 
            //(int)(playerModelSize.Width/1.3))));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursach.Entites;
using System.Drawing;

namespace Kursach.Models
{
    public class Gladiator: Entity
    {
        public Gladiator()
        {

        }

        public Gladiator(int posX, int posY, Image spriteSheet): base(posX, posY, spriteSheet)
        {
            size = 31;
            idleFrames = 5;
            runFrames = 8;
            attackFrames = 7;
            deathFrames = 7;
            currentLimit = idleFrames;
            playerModelSize = new Size(150, 150);
            hitPoints = 3;
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
            if (player.posY > posY)
                dirY = 5;
            else if (player.posY < posY)
                dirY = -5;
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
                    break;

            }
        }

        public override void PlayAnimation(Graphics g)
        {
            if (currentFrame < currentLimit - 1)
                currentFrame++;
            else currentFrame = 0;
            g.DrawImage(spriteSheet, new Rectangle(new Point(posX, posY), playerModelSize), 
                32f * currentFrame, 32 * currentAnimation, size, size, GraphicsUnit.Pixel);
            //Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
            //g.DrawRectangle(blackPen, new Rectangle(new Point(posX, posY), playerModelSize));
        }
    }
}

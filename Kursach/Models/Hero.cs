using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursach.Entites;
using System.Drawing;


namespace Kursach.Models
{
    public class Hero: Entity
    {
        public bool isRight;
        public bool isLeft;
        public bool isTop;
        public bool isBottom;

        public bool isAttack;
        public bool attackIsOver;
        public bool spaceIsUp;

        public Hero()
        {

        }
        public Hero(int posX, int posY, Image spriteSheet): base(posX, posY, spriteSheet)
        {
            size = 31;
            idleFrames = 5;
            runFrames = 8;
            attackFrames = 7;
            deathFrames = 7;
            currentLimit = idleFrames;

            isBottom = false;
            isLeft = false;
            isRight = false;
            isTop = false;

            isAttack = false;
            attackIsOver = true;
            spaceIsUp = true;

            playerModelSize = new Size(150, 150);

            hitPoints = 1;
        }

        override public void SetAnimationConfiguration(int currentAnimation)
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
                    currentLimit = attackFrames;
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
            }
        }

        override public void Move(int howMove)
        {
            switch(howMove)
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

        public void PlayAttack(Graphics g)
        {
            if (currentFrame < currentLimit - 1)
                currentFrame++;
            else
            {
                currentFrame = 0;
                attackIsOver = true;
            }
            g.DrawImage(spriteSheet, new Rectangle(new Point(posX, posY), new Size(100, 100)), 32f * currentFrame, 32 * currentAnimation, size, size, GraphicsUnit.Pixel);
        }
    }
}

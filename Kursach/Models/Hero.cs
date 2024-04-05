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

        public int powerOfAttack;

        public bool isFinal;

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

            hitPoints = 3;

            powerOfAttack = 1;

            isFinal = false;

            spriteSheetUnderAttack = new Bitmap(@"C:\Users\dmosi\source\repos\Kursach\Kursach\Sprites\DwarfUnderAttack.png");
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
                case 9:
                    currentLimit = deathFrames;
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

            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 2);
            //(flip == 1)
              //  g.DrawRectangle(blackPen, new Rectangle(new Point(posX+playerModelSize.Width-45, posY+40), new Size(50, playerModelSize.Width-40)));
            //else g.DrawRectangle(blackPen, new Rectangle(new Point(posX+5, posY + 40), new Size(45, playerModelSize.Width - 40)));
            //g.DrawRectangle(blackPen, new Rectangle(new Point(posX+30, posY+50), new Size((int)(playerModelSize.Width / 1.5),
            //(int)(playerModelSize.Width / 1.5))));
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Kursach.Entites
{
    abstract public class Entity
    {
        public int posX;
        public int posY;

        public int dirX;
        public int dirY;
        public bool isMoving;

        public int flip;

        public int currentAnimation;
        public int currentFrame;
        public int currentLimit;

        protected int idleFrames;
        protected int runFrames;
        protected int attackFrames;
        protected int deathFrames;

        public int size;

        public Image spriteSheet;
        public Image spriteSheetUnderAttack;

        public Size playerModelSize;

        public int hitPoints;

        public bool isUnderAttack;

        public Entity()
        {

        }

        public Entity(int posX, int posY, Image spriteSheet)
        {
            this.posX = posX;
            this.posY = posY;
            dirX = 0;
            dirY = 0;
            this.spriteSheet = spriteSheet;
            currentAnimation = 0;
            currentFrame = 0;
            flip = 1;
            isMoving = false;
            isUnderAttack = false;
        }

        virtual public void Move(int howMove)
        {
        }

        virtual public void PlayAnimation(Graphics g)
        {
        }

        virtual public void SetAnimationConfiguration(int currentAnimation)
        {
        }
    }
}

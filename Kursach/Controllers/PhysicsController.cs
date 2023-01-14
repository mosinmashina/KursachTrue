using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursach.Models;
using Kursach.Entites;

namespace Kursach.Controllers
{
    public static class PhysicsController
    {
        public static int isOutOfMap(Hero player)
        {
            if (player.posY + player.dirY >= -30 && player.posY + player.dirY + player.playerModelSize.Width <= 1080 &&
                player.posX + player.dirX >= 0 && player.posX + player.dirX + player.playerModelSize.Width <= 1920)
                return 0;
            if (player.posY + player.dirY >= -30 && player.posY + player.dirY + player.playerModelSize.Width <= 1080)
                return 1;
            if (player.posX + player.dirX >= 0 && player.posX + player.dirX + player.playerModelSize.Width <= 1920)
                return 2;
            return -1;
        }

        public static bool isCollide(Entity entityOne, Entity entityTwo)
        {
            if (entityOne.posX + entityOne.playerModelSize.Width / 1.5 + 30 < entityTwo.posX + 22 ||
                entityOne.posX + 30 > entityTwo.posX + entityTwo.playerModelSize.Height / 1.5 + 22)
                return false;
            if (entityOne.posY + entityOne.playerModelSize.Width / 1.5 + 50 < entityTwo.posY + 30 ||
                entityOne.posY + 50 > entityTwo.posY + entityTwo.playerModelSize.Height / 1.3 + 30)
                return false;
            return true;
        }

        public static bool isAttack(Entity entityOne, Entity entityTwo)
        {
            if (entityOne.flip == 1 && isCollideAttack(entityOne, entityTwo, 1))
            {
                entityTwo.posX += 50;
                return true;
            }
            else if (isCollideAttack(entityOne, entityTwo, -1))
            {
                entityTwo.posX -= 50;
                return true;
            }
            return false;
        }

        private static bool isCollideAttack(Entity entityOne, Entity entityTwo, int flip)
        {
            int xOneMin, xOneMax, yOneMin, yOneMax;
            int xTwoMin, xTwoMax, yTwoMin, yTwoMax;
            if (flip == 1)
            {
                xOneMin = entityOne.posX + entityOne.playerModelSize.Width - 45;
                xOneMax = xOneMin + 50;
                yOneMin = entityOne.posY + 40;
                yOneMax = yOneMin + entityOne.playerModelSize.Width - 40;
            }
            else
            {
                xOneMin = entityOne.posX + 5;
                xOneMax = xOneMin + 45;
                yOneMin = entityOne.posY + 40;
                yOneMax = yOneMin + entityOne.playerModelSize.Width - 40;
            }
            xTwoMin = entityTwo.posX + 22;
            xTwoMax = xTwoMin + (int)(entityTwo.playerModelSize.Width / 1.5);
            yTwoMin = entityTwo.posY + 30;
            yTwoMax = yTwoMin + (int)(entityTwo.playerModelSize.Width /1.3);
            if (xOneMax < xTwoMin || xOneMin > xTwoMax)
                return false;
            if (yOneMax < yTwoMin || yOneMin > yTwoMax)
                return false;
            return true;
        }
    }
}

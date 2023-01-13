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
            if (entityOne.posX + entityOne.playerModelSize.Width/1.5 < entityTwo.posX ||
                entityOne.posX > entityTwo.posX + entityTwo.playerModelSize.Height/1.5)
                return false;
            if (entityOne.posY + entityOne.playerModelSize.Width/1.5 < entityTwo.posY ||
                entityOne.posY > entityTwo.posY + entityTwo.playerModelSize.Height/1.5)
                return false;
            return true;
        }

        public static bool isAttack(Entity entityOne, Entity entityTwo)
        {
            
            return true;
        }
    }
}

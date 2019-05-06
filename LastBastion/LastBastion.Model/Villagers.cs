using System;
using System.Collections.Generic;
using System.Text;

namespace LastBastion.Model
{
    public class Villagers : Units
    {
        uint _harvestCooldown = 3;


        public Villagers(bool flying, double posX, double posY,
            string job, uint lifePoints, uint dmg, uint armor, bool isMoving,
            uint attackCooldown, double speed)
            :base(flying, posX,posY,
            job, lifePoints, dmg, armor, isMoving,
            attackCooldown,speed)
        {
        }

        public uint HarvestCd => _harvestCooldown;
    }
}

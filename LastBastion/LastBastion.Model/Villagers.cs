using System;
using System.Collections.Generic;
using System.Text;

namespace LastBastion.Model
{
    public class Villagers : Units
    {
        uint _harvestCooldown = 3;

        public Villagers(bool flying, float posX, float posY,
            string job, uint lifePoints, uint dmg, uint armor, bool isMoving,
            uint attackCooldown, float speed)
            :base(flying, posX,posY,
            job, lifePoints, dmg, armor, isMoving,
            attackCooldown,speed)
        {
        }

        public uint HarvestCd => _harvestCooldown;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LastBastion.Model
{
    public class Barbars : Units
    {
        static uint _count;

        public Barbars(bool flying, float posX, float posY,
            string job, uint lifePoints, uint dmg, uint armor, bool isMoving,
            uint attackCooldown, float speed)
            :base(flying, posX, posY,
            job, lifePoints, dmg, armor, isMoving,
            attackCooldown, speed)
        {
            _count++;
        }


        /**public void Move(double x, double Y)
        {
            _isMoving = !isMoving;
        }*/
    }
}
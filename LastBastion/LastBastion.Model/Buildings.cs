using System;
using System.Collections.Generic;
using System.Text;

namespace LastBastion.Model
{
    public abstract class Buildings
    {
        readonly float _posX;
        readonly float _posY;
        static uint _count;

        public Buildings(float posX, float posY)
        {
            _posX = posX;
            _posY = posY;
            _count++;
        }
    }
}

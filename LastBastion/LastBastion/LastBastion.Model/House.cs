using System;
using System.Collections.Generic;
using System.Text;

namespace LastBastion.Model
{
    public class House : Buildings
    {
        uint _population;

        public House(float posX,float posY,uint lifePoints, uint maxLifePoints,uint armor, uint rank, uint population)
            :base(posX,posY,lifePoints,armor,rank)
        {
            _population = population;
        }

        public uint Population
        {
            get { return _population; }
            set { _population = value; }
        }

        public void IncPop ()
        {
            _population += 10;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LastBastion.Model
{
    public class Sawmill : Buildings
    {
        uint _woodProduction;

        public Sawmill (float posX, float posY, uint lifePoints, uint armor, uint rank, uint woodProduction)
            : base(posX, posY, lifePoints, armor, rank)
        {
            _woodProduction = woodProduction;
        }

        public void IncWoodProd ()
        {
            _woodProduction += 2;
        }

        public uint WoodProduction
        {
            get { return _woodProduction; }
            set { _woodProduction = value; }
        }
    }
}

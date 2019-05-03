using System;
using System.Collections.Generic;
using System.Text;

namespace LastBastion.Model
{
    public class Mine : Buildings
    {
        uint _stoneProduction;

        public Mine(float posX, float posY, uint lifePoints, uint armor, uint rank, uint stoneProduction)
            : base(posX, posY, lifePoints, armor, rank)
        {
            _stoneProduction = stoneProduction;
        }

        public void IncStoneProd()
        {
            _stoneProduction += 2;
        }

        public uint StoneProduction
        {
            get { return _stoneProduction; }
            set { _stoneProduction = value; }
        }
    }
}
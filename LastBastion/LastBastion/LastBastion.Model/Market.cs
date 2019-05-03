using System;
using System.Collections.Generic;
using System.Text;

namespace LastBastion.Model
{
    public class Market : Buildings
    {
        uint _foodProduction;

        public Market(float posX, float posY, uint lifePoints, uint armor, uint rank, uint foodProduction)
            : base(posX, posY, lifePoints, armor, rank)
        {
            _foodProduction = foodProduction;
        }

        public void IncFoodProd()
        {
            _foodProduction += 2;
        }

        public uint FoodProduction
        {
            get { return _foodProduction; }
            set { _foodProduction = value; }
        }
    }
}

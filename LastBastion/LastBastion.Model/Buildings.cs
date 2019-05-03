using System;
using System.Collections.Generic;
using System.Text;

namespace LastBastion.Model
{
    public class Buildings
    {
        readonly float _posX;
        readonly float _posY;
        uint _lifePoints;
        uint _maxLifePoints;
        static uint _count;
        uint _armor;
        uint _rank;

        public Buildings(float posX, float posY, uint lifePoints,  uint armor,  uint rank)
        {
            _posX = posX;
            _posY = posY;
            _lifePoints = lifePoints;
            _maxLifePoints = lifePoints;
            _armor = armor;
            _rank = rank;
            _count++;
        }

        public uint Dmg => _dmg;

        public uint Armor => _armor;

        public void IncreaseArmor()
        {
            _armor++;
        }

        public void IncDamage()
        {
            _dmg *=  2;
        }

        public void IncHealth()
        {
            _maxLifePoints  *= 2;
            _lifePoints *= 2;

        }

        public uint MaxLife => _maxLifePoints;

        public uint Life => _lifePoints;


        public void Attack(Units unit)
        {
            if (_dmg > unit.Life)
            {
                unit.Attacked(0);
                unit.Die();
                return;
            }
            unit.Attacked(Math.Max(unit.Life - (_dmg - unit.Armor), 0));
        }

    }
}

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
        uint _dmg;
        uint _armor;
        uint _aaCooldown;
        uint _rank;

        public Buildings(float posX, float posY, uint lifePoints, uint dmg, uint armor, uint attackCooldown, uint rank)
        {
            _posX = posX;
            _posY = posY;
            _lifePoints = lifePoints;
            _maxLifePoints = lifePoints;
            _dmg = dmg;
            _armor = armor;
            _aaCooldown = attackCooldown;
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
            _dmg = _dmg * 2;
        }

        public void IncHealth()
        {
            _maxLifePoints = _maxLifePoints * 2;
        }

        public uint MaxLife => _maxLifePoints;

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

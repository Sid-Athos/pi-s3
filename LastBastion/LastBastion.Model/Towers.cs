using System;
using System.Collections.Generic;
using System.Text;

namespace LastBastion.Model
{
    public class Towers
    {
        uint _lifePoints = 30;
        uint _maxLifePoints = 30;
        static uint _count;
        uint _dmg = 5;
        bool _attackable;
        uint _armor = 0;                        // each armor point reduces damages by 10%.
        bool _isMoving = false;
        uint _aaCooldown = 3;                // AutoAttacks cooldown
        Archer[] _slots;
        uint _rank = 1;

        public Tower(float posX, float posY)
            :base(posX,posY)
        {
            _count++;
            _job = job;
            _posX = posX;
            _posY = posY;
            _attackable = true;
            _slots = new Archer[2];
        }

        public uint Count => _count;

        public string Jobs => _job;

        public uint Dmg => _dmg;

        public uint Armor => _armor;

        public uint AttackCooldown => _aaCooldown;

        public void Upgrade()
        {
            if (_rank < 3)
            {
                _rank++;
                Archer[] newSlots = Archer[_slots.Length * 2];
                for (int i = 0; i < _slots.Length; i++)
                {
                    newSlots[i] = _slots[i];
                }

                _armor++;
                _dmg = _dmg * 2;
                _maxLifePoints = _maxLifePoints * 2;
                _slots = newSlots;
            }
        }
    }
}

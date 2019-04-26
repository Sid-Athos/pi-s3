using System;
using System.Collections.Generic;
using System.Text;

namespace LastBastion.Model
{
    public class Barbars : Units
    {
        static uint _count;
        uint _lifePoints = 30;
        static uint _count;
        readonly uint _dmg = 5;
        bool _attackable;
        readonly uint _armor = 0;                        // each armor point reduces damages by 10%.
        bool _isMoving = false;
        uint _aaCooldown = 3;                // AutoAttacks cooldown
        Barbars[] _slots;
        float _speed = 1.0;

        public Barbar()
            :base(Map context, bool flying, float posX, float posY)
        {
            _count++;
            _attackable = true;
        }

        public void Attack(var unit)
        {
            unit._lifePoints = unit._lifePoints - (_dmg - unit.armor);
        }

        public uint Count => _count;

        public string Jobs => _job;

        public uint Dmg => _dmg;

        public uint Armor => _armor;

        public void Move(double x, double Y)
        {
            // Other code here
            _isMoving = !isMoving;
        }

        public bool IsMoving => _isMoving;
    }
}

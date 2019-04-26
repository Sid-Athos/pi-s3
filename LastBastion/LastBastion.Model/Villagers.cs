using System;
using System.Collections.Generic;
using System.Text;

namespace LastBastion.Model
{
    public class Villagers : Units
    {
        uint _lifePoints = 20;
        readonly string _job;
        readonly uint _dmg = 1;
        bool _attackable;
        readonly uint _armor = 0;                        // each armor point reduces damages by 10%.
        bool _isMoving = false;
        uint _aaCooldown = 2;                // AutoAttacks cooldown
        float _speed = 1.0f;

        uint _harvestCooldown = 3;

        public Villager( string job)
            :base(Map context,bool flying, float posX, float posY)
        {
            _job = job;
            base._villagePeople.add(this);
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

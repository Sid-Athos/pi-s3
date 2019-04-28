using System;
using System.Collections.Generic;

namespace LastBastion.Model
{
    public class Units
    {
        //Map _context;
        public bool _flying;
        float _posX;
        float _posY;
        readonly string _job;
        uint _lifePoints;
        uint _maxLifePoints;
        readonly uint _dmg;
        readonly uint _armor;                        // each armor point reduces damages by 10%.
        bool _isMoving;
        uint _aaCooldown;                // AutoAttacks cooldown
        float _speed;
        static List<Villagers> _villagePeople = new List<Villagers>();
        static List<Barbars> _barbarians = new List<Barbars>();
        public bool _burned = false;
        public bool _paralyzed = false;

        public Units(bool flying, float posX, float posY, 
            string job, uint lifePoints, uint dmg, uint armor, bool isMoving, 
            uint attackCooldown, float speed)
        {
            //_context = context;
            _flying = flying;
            _posX = posX;
            _posY = posY;
            _job = job;
            _lifePoints = lifePoints;
            _maxLifePoints = lifePoints;
            _dmg = dmg;
            _armor = armor;
            _isMoving = isMoving;
            _aaCooldown = attackCooldown;
            _speed = speed;
        }

        public void Attack(Units unit)
        {
            unit._lifePoints = unit._lifePoints - (_dmg - unit._armor);
        }

        public int BarbCount => _barbarians.Count;

        public int VillagerCount => _villagePeople.Count;

        public uint Dmg => _dmg;

        public uint Armor => _armor;

        public bool IsMoving => _isMoving;

        public string Job => _job;
    }
}

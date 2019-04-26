using System;
using System.Collections.Generic;

namespace LastBastion.Model
{
    public abstract class Units
    {
        float _posX;
        float _posY;
        List<Villager> _villagePeople = new List<Villager>;
        List<Barbars> _barbarians = new List<Barbars>;
        public bool _flying;
        Map _context;

        public bool _burned = false;
        public bool _paralyzed = false;

        public Units(Map context, bool flying, float posX, float posY)
        {
            _context = context;
            _flying = flying;
        }

        public uint BarbCount => _barbarians.Count;

        public uint VillagerCount => _villager.Count;
    }
}

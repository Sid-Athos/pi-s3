using System;
using System.Collections.Generic;
using System.Text;

namespace LastBastion.Model
{
    public class Towers : Buildings
    {
        
        Villagers [] _slots;
        uint _rank = 1;

        public Towers(float posX,
        float posY,
        uint lifePoints,
        uint dmg,
        uint armor,
        uint aaCooldown,
        uint rank)
            :base( posX,
         posY,
         lifePoints,
         dmg,
         armor,
         aaCooldown,
         rank)
        {
            _slots = new Villagers[2];
        }

        public uint Rank => _rank;

        public int AvailableSlots => _slots.Length;

        public void Upgrade()
        {
            if (_rank < 3)
            {
                _rank++;
                Villagers[] newSlots = new Villagers[_slots.Length * 2];
                for (int i = 0; i < _slots.Length; i++)
                {
                    newSlots[i] = _slots[i];
                }

                IncreaseArmor();
                IncDamage();
                IncHealth();
                _slots = newSlots;
            }
        }

        public void AddArcher(Villagers u)
        {
            if(!u.IsInTower)
            {
                _slots.SetValue(u,ShowArchers());
                u.JoinTower(); 
            }
        }

        public uint ShowArchers()
        {
            uint compteur = 0;

            for (int i = 0; i < _slots.Length; i++)
            {
                if (_slots[i] != null )
                {
                    compteur++;
                }
            }

            return compteur;
        }
    }
}
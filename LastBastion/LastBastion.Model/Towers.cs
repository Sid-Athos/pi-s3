using System;
using System.Collections.Generic;
using System.Text;

namespace LastBastion.Model
{
    public class Towers : Buildings
    {
        
        int [] _slots;
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
            _slots = new int[2];
        }

        public uint Rank => _rank;

        public int AvailableSlots => _slots.Length;

        public void Upgrade()
        {
            if (_rank < 3)
            {
                _rank++;
                int[] newSlots = new int[_slots.Length * 2];
                for (int i = 0; i < _slots.Length; i++)
                {
                    newSlots[i] = _slots[i];
                }

                this.IncreaseArmor();
                this.IncDamage();
                this.IncHealth();
                _slots = newSlots;
            }
        }
    }
}

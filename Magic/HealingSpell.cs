using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarksReachRemake.Magic
{
    public class HealingSpell : Spell
    {
        public HealingSpell()
        {
            HealingSpell = true;
            
        }
        public override void Cast(Player p, Monster m)
        {
            if (p.mana - cost < 0)
            {
                System.Windows.Forms.MessageBox.Show("You do not have enough mana to cast this spell!");
            }
            else
            {
                if (p.health == p.maxHealth)
                {
                    System.Windows.Forms.MessageBox.Show("You already have maximum health!", "Error");
                }
                else
                {
                    p.mana -= cost;
                    p.HealHealth(healingAmount + p.Level);
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarksReachRemake
{
    public class Spell
    {
        public string name { get; set; }
        public int damage { get; set; }
        public int cost { get; set; }
        public bool CombatSpell { get; set; }
        public bool HealingSpell { get; set; }
        public int healingAmount { get; set; }
        public void Learn()
        {
            if (!Program.player.spellBook.Contains(this))
            {
                Program.player.spellBook.Add(this);
            }
        }
        public string Display
        {
      
            get
            {
                if (HealingSpell)
                {
                    return string.Format("{0} - {1} mana, {2} health", name, cost, healingAmount);

                }else if (CombatSpell)
                {
                    return string.Format("{0} - {1} mana, {2} damage", name, cost, damage);

                }else
                {
                    return string.Format("{0} - {1} mana", name, cost);

                }
            }
        }
        public virtual void Cast(Player p, Monster m)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarksReachRemake.Magic
{
    public class FireSpell : Spell
    {
        public int burnChance { get; set; } //Will cause a burn 1/burnChance times. ie burnchance = 5 so they will get burned once every 5 spell casts
        public FireSpell()
        {
            CombatSpell = true;
        }
        Random r = new Random();
        public override void Cast(Player p, Monster m)
        {
            if (p.mana - cost < 0)
            {
                System.Windows.Forms.MessageBox.Show("You do not have enough mana to cast this spell!");
            }
            else
            {
                
                p.mana -= cost;
                m.health -= (damage);
                if(r.Next(0, burnChance) == 0)
                {
                    m.burned = true;
                }
                Combat.enemyAttacked = true;
                if (m.health <= 0)
                {
                    m.health = 0;
                    Combat.enemyAttacked = false;
                    Combat.playerAttacked = false;
                    m.Kill();
                }
                else
                {
                    Combat.EnemyAttack(m, p);
                    Combat.playerAttacked = true;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarksReachRemake.Magic
{
    public class CombatSpell : Spell
    {
        public CombatSpell()
        {
            CombatSpell = true;
        }
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
                Combat.enemyAttacked = true;
                if(m.health <= 0)
                {
                    m.health = 0;
                    Combat.enemyAttacked = false;
                    Combat.playerAttacked = false;
                    m.Kill();
                }else
                {
                    Combat.EnemyAttack(m, p);
                    Combat.playerAttacked = true;
                }
            }
        }
    }
}

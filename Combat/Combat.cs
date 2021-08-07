using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarksReachRemake
{
    public class Combat
    {
        public static bool running { get; set; }
        public static Monster foughtMonster { get; set; }
        public static int turn = 0;
        public static int damageModifier { get; set; }
        public static bool runSucceed { get; set; }
        public static bool playerAttacked { get; set; }
        public static int totalEnemyDamage { get; set; }
        public static bool enemyAttacked { get; set; }
        public static int totalPlayerDamage { get; set; }
        public static void Begin(Monster m, Player p)
        {
            Entities.SetEntities.SetDefaults();
            running = true;
            foughtMonster = m;
        }

        public static void Attack(Monster m, Player p)
        {
            totalPlayerDamage = p.totalDamage + damageModifier; 
            damageModifier = DarksReachForm.rand.Next(-1, 2);
            m.health -= totalPlayerDamage;
            enemyAttacked = true;

            if(m.health <= 0)
            {
                m.health = 0;
                m.Kill();
                playerAttacked = false;
            }else
            {
                EnemyAttack(m,p);
            }
        }
        public static void MagicAttack(Spell s, Monster m, Player p)
        {
            if (s.CombatSpell)
            {
                s.Cast(p, m);
                if(m.health <= 0)
                {
                    m.health = 0;
                    m.Kill();
                }
            }
            else if (s.HealingSpell)
            {
                s.Cast(p, m);
            }

        }
        public static void Run(Monster m, Player p)
        {
            if (!m.boss)
            {
                if (DarksReachForm.rand.Next(0, m.runChance) == 0)
                {
                    Combat.End(m, p);
                    runSucceed = true;
                    playerAttacked = false;
                }
                else
                {
                    EnemyAttack(m, p);
                    runSucceed = false;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("You cannot run away from a boss!");
            }

        }
        public static void EnemyAttack(Monster m, Player p)
        {
            damageModifier = DarksReachForm.rand.Next(0, 2);
            totalEnemyDamage = m.damage + damageModifier;
            p.Hurt(totalEnemyDamage);
            playerAttacked = true;
            if (m.burned)
            {
                m.health--;
                if(m.health <= 0)
                {
                    m.health = 0;
                    m.Kill();
                    playerAttacked = false;
                    enemyAttacked = false;
                }else
                {
                    m.damage--;

                    if (m.damage <= 1)
                    {
                        m.damage = 1;
                    }
                    playerAttacked = true;
                }

            }
        }
        public static void End(Monster m, Player p)
        {
            running = false;
            playerAttacked = false;
            enemyAttacked = false;
            p.Location.deadRoom = true;
            
        }
    }
}

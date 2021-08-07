using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarksReachRemake.Items;
namespace DarksReachRemake
{
    public class Monster : Entity
    {
        public int maxHealth { get; set; }
        public List<Item> Loot = new List<Item>();
        public int dropChance { get; set; } //Setup dropping on death
        public int runChance { get; set; }
        public int maxXP { get; set; }
        public bool burned { get; set; }
        public int minXP { get; set; }
        Random r = new Random();
        public Monster()
        {
            burned = false;
            alive = true;
            boss = false;
        }
        public void Kill()
        {
            Combat.End(this, Program.player);
            Drop(Program.player);
            health = maxHealth;
            alive = false;
            
        }
        public void Drop(Player p)
        {
            int dropped = r.Next(0, dropChance);
            if(Loot.Count > 0)
            {
                if (dropped == 0)
                {
                    p.GiveItem(Loot[r.Next(0, Loot.Count)]);
                }
            }
            p.xp += r.Next(minXP, (maxXP + 1));
            p.LevelUp();
        }
    }
}

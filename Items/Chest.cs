using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarksReachRemake.Movement;
namespace DarksReachRemake.Items
{
    public class Chest
    {
        public List<Item> chestLoot = new List<Item>();
        public bool random { get; set; }
        public bool added { get; set; }
        public bool used { get; set; }
        public Chest()
        {

        }
        public void Open()
        {
            if (random)
            {
               int lootDropped = DarksReachForm.rand.Next(0, chestLoot.Count());
                Program.player.GiveItem(chestLoot[lootDropped]);
            }else
            {
                for (int i = 0; i < chestLoot.Count(); i++)
                {
                    Program.player.GiveItem(chestLoot[i]);
                }
            }
            used = true;
        }
        public void Open(int itemsDropped)
        {
            if (random)
            {
                for (int i = 0; i < itemsDropped; i++)
                {
                    int lootDropped = DarksReachForm.rand.Next(0, chestLoot.Count());
                    Program.player.GiveItem(chestLoot[lootDropped]);
                }
            }else
            {
                for (int i = 0; i < itemsDropped; i++)
                {
                    Program.player.GiveItem(chestLoot[i]);
                }
            }
            used = true;
        }
        public void Open(int itemsDropped, bool _random)
        {
            random = _random;
            if (random)
            {
                for (int i = 0; i < itemsDropped; i++)
                {
                    int lootDropped = DarksReachForm.rand.Next(0, chestLoot.Count());
                    Program.player.GiveItem(chestLoot[lootDropped]);
                }
            }
            else
            {
                for (int i = 0; i < itemsDropped; i++)
                {
                    Program.player.GiveItem(chestLoot[i]);
                }
            }
            used = true;
        }
    }
}

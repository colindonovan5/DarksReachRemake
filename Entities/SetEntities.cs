using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarksReachRemake.Items;
namespace DarksReachRemake.Entities
{
    public static class SetEntities
    {
        public static Monster Tiger = new Monster();
        public static Monster Goblin = new Monster();
        public static Monster Nightmare = new Monster();
        public static Monster Zombie = new Monster();
        public static Monster PossessedCow = new Monster();
        public static Monster Vampire = new Monster();
        public static Monster StormCloud = new Monster();

        public static Boss Solix = new Boss();

        public static void SetDefaults()
        {
            //Goblin
            Goblin.name = "Goblin";
            Goblin.damage = 2 + Program.player.Level;
            Goblin.maxHealth = 9 + Program.player.Level;
            Goblin.health = Goblin.maxHealth;
            Goblin.Loot.Add(SetItems.CopperSword);
            Goblin.dropChance = 3;
            Goblin.runChance = 3;
            Goblin.maxXP = 15;
            Goblin.minXP = 5;

            //Zombie
            Zombie.name = "Zombie";
            Zombie.damage = 1 + Program.player.Level;
            Zombie.maxHealth = 14 + Program.player.Level;
            Zombie.health = Zombie.maxHealth;
            Zombie.Loot.Add(SetItems.ZombieArm);
            Zombie.dropChance = 3;
            Zombie.runChance = 3;
            Zombie.maxXP = 20;
            Zombie.minXP = 10;

            //Nightmare
            Nightmare.name = "Nightmare";
            Nightmare.damage = Program.player.damage / 2;
            Nightmare.health = Program.player.health / 2;
            Nightmare.maxHealth = Program.player.health / 2;
            Nightmare.Loot.Add(SetItems.NightmareDust);
            Nightmare.runChance = 3;
            Nightmare.dropChance = 10;
            Nightmare.maxXP = 0;
            Nightmare.minXP = 0;

            //Possessed Cow
            PossessedCow.name = "Possessed Cow";
            PossessedCow.damage = 2 + Program.player.Level;
            PossessedCow.maxHealth = 11 + Program.player.Level;
            PossessedCow.health = PossessedCow.maxHealth;
            PossessedCow.Loot.Add(SetItems.RottedBeef);
            PossessedCow.runChance = 3;
            PossessedCow.dropChance = 3;
            PossessedCow.minXP = 20;
            PossessedCow.maxXP = 30;

            //Vampire
            Vampire.name = "Vampire";
            Vampire.damage = 2 + Program.player.Level;
            Vampire.maxHealth = 14 + Program.player.Level;
            Vampire.health = Vampire.maxHealth;
            Vampire.Loot.Add(SetItems.VialOfBlood);
            Vampire.runChance = 5;
            Vampire.dropChance = 5;
            Vampire.minXP = 15;
            Vampire.maxXP = 30;

            //Tiger
            Tiger.name = "Tiger";
            Tiger.damage = 3 + Program.player.Level;
            Tiger.maxHealth = 14 + Program.player.Level;
            Tiger.health = Tiger.maxHealth;
            Tiger.Loot.Add(SetItems.TigerFang);
            Tiger.runChance = 4;
            Tiger.dropChance = 3;
            Tiger.minXP = 20;
            Tiger.maxXP = 30;

            //Solix
            Solix.name = "Solix";
            Solix.damage = 5 + Program.player.Level;
            Solix.maxHealth = 19 + Program.player.Level;
            Solix.health = Solix.maxHealth;
            Solix.Loot.Add(SetItems.Sol);
            Solix.runChance = 100;
            Solix.dropChance = 1;
            Solix.minXP = 45;
            Solix.maxXP = 55;

            //Storm Cloud
            StormCloud.name = "Storm Cloud";
            StormCloud.damage = 2 + Program.player.Level;
            StormCloud.maxHealth = 24 + Program.player.Level;
            StormCloud.health = StormCloud.maxHealth;
            StormCloud.Loot.Add(SetItems.SmallHealingPotion);
            StormCloud.runChance = 4;
            StormCloud.dropChance = 3;
            StormCloud.minXP = 30;
            StormCloud.maxXP = 35;
        }
            
        

    }
}

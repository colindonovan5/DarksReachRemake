using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarksReachRemake.Items
{
    public class SetItems
    {
        public static Weapon CopperSword = new Weapon();
        public static Weapon IronSword = new Weapon();
        public static Weapon Stick = new Weapon();
        public static Weapon ZombieArm = new Weapon();
        public static Weapon Guitar = new Weapon();
        public static Potion SmallHealingPotion = new Potion();
        public static Potion RottedBeef = new Potion();
        public static Weapon TigerFang = new Weapon();
        public static Item NightmareDust = new Item();
        public static Item VialOfBlood = new Item();
        public static Weapon Sol = new Weapon();

        public static void SetDefaults()
        {
            //Copper Sword
            CopperSword.name = "Copper Sword";
            CopperSword.damage = 2;
            CopperSword.amount = 1;
            CopperSword.maxStack = 1;
 
            //Iron Sword
            IronSword.name = "Iron Sword";
            IronSword.damage = 3;
            IronSword.amount = 1;
            IronSword.maxStack = 1;
            
            //Stick
            Stick.name = "Stick";
            Stick.damage = 1;
            Stick.amount = 1;
            Stick.maxStack = 1;
            
            //Small Healing Potion
            SmallHealingPotion.name = "Small Healing Potion";
            SmallHealingPotion.amount = 1;
            SmallHealingPotion.maxStack = 99;
            SmallHealingPotion.healingAmount = 10;

            //Nightmare Dust
            NightmareDust.name = "Nightmare Dust";
            NightmareDust.amount = 1;
            NightmareDust.maxStack = 99;
            NightmareDust.misc = true;

            //Zombie Arm
            ZombieArm.name = "Zombie Arm";
            ZombieArm.amount = 1;
            ZombieArm.maxStack = 1;
            ZombieArm.damage = 2;

            //Guitar
            Guitar.name = "Guitar";
            Guitar.amount = 1;
            Guitar.damage = 2;

            //Rotted Beef
            RottedBeef.name = "Rotted Beef";
            RottedBeef.amount = 1;
            RottedBeef.healingAmount = 8;

            //Vial of Blood
            VialOfBlood.name = "Vial of Blood";
            VialOfBlood.amount = 1;
            VialOfBlood.maxStack = 1;
            VialOfBlood.misc = true;

            //Tiger Fang
            TigerFang.name = "Tiger Fang";
            TigerFang.amount = 1;
            TigerFang.maxStack = 1;
            TigerFang.damage = 3;

            //Sol
            Sol.name = "Sol";
            Sol.amount = 1;
            Sol.maxStack = 1;
            Sol.damage = 5;
        } 
    }
}

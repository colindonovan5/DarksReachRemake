using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarksReachRemake.Entities;
using DarksReachRemake.Items;
namespace DarksReachRemake.Movement.Rooms
{
    class SetRooms
    {
        //WHEN MAKING A NEW ROOM MAKE SURE TO RUN ITS CHECKROOM IN THE PLAYER CLASS

        //--------------------Rooms----------------------
        public static Location StartingRoom = new Location();
        public static Location FirstChestRoom = new Location();
        public static Location FirstMonsterRoom = new Location();
        public static Location DarkStatueRoom = new Location();
        public static Location PartyRoom = new Location();
        public static Location RestRoom = new Location();
        public static Location SpaceRoom = new Location();
        public static Location SmallRoom = new Location();
        public static Location PurpleRoom = new Location();
        public static Location GuitarRoom = new Location();
        public static Location CrumplingRoom = new Location();
        public static Location LeatherRoom = new Location();
        public static Location CakeRoom = new Location();
        public static Location SunRoom = new Location();
        public static Location BloodyRoom = new Location();
        public static Location TornUpRoom = new Location();
        public static Location BalletRoom = new Location();
        public static Location TigerRoom = new Location();
        public static Location GoldenRoom = new Location();
        public static Location BugRoom = new Location();
        public static Location PlaneRoom = new Location();
        public static Location RadioRoom = new Location();
        public static Location SolixRoom = new Location();
        public static Location LibraryRoom = new Location();
        public static Location CloudRoom = new Location();
        public static Location MoonRoom = new Location();
        public static Location WetRoom = new Location();
        public static Location LightningRoom = new Location();
        public static Location ClassRoom = new Location();

        //-------------------Chests--------------------
        public static Chest SmallHealingPotionChest = new Chest();
        public static Chest GuitarChest = new Chest();

        public static void SetDefaults()
        {

            //-----------------First Floor-----------------

            //Dark Room
            StartingRoom.name = "Dark Room";
            StartingRoom.x = 0;
            StartingRoom.y = 0;
            StartingRoom.description = "The lights are out and you can't see anything.";
            
            //Chest Room
            FirstChestRoom.name = "Chest Room";
            FirstChestRoom.x = 1;
            FirstChestRoom.y = 0;
            FirstChestRoom.description = "There is a chest sitting against the wall.";
            FirstChestRoom.chest = SmallHealingPotionChest;
            if (!SmallHealingPotionChest.added)
            {
                SmallHealingPotionChest.chestLoot.Add(SetItems.SmallHealingPotion);
                SmallHealingPotionChest.added = true;
            }

            //Smelly Room
            FirstMonsterRoom.name = "Smelly Room";
            FirstMonsterRoom.x = 0;
            FirstMonsterRoom.y = 1;
            FirstMonsterRoom.description = "There is a horrible smell coming from the corner of the room. You spot a strange creature standing there.";
            if(FirstMonsterRoom.monsterAdded == false)
            {
                FirstMonsterRoom.monsters.Add(SetEntities.Goblin);
                FirstMonsterRoom.monsterAdded = true;
            }

            //Statue Room
            DarkStatueRoom.name = "Statue Room";
            DarkStatueRoom.x = 1;
            DarkStatueRoom.y = 1;
            DarkStatueRoom.description = "A large statue of a strange figure envelops the center of the room. It is strange to look at. It is almost as if it has an invisible cloak around it.";

            //Party Room
            PartyRoom.name = "Party Room";
            PartyRoom.x = 2;
            PartyRoom.y = 0;
            PartyRoom.description = "The lights in the room are strobing and it looks like there could be a pretty sweet party if it wasn't in the middle of a dungeon.";
            if (!PartyRoom.monsterAdded)
            {
                PartyRoom.monsters.Add(SetEntities.Zombie);
                PartyRoom.monsterAdded = true;
            }
            //Rest Room
            RestRoom.name = "Rest Room";
            RestRoom.x = 0;
            RestRoom.y = 2;
            RestRoom.description = "There is a strange feeling in this room. It makes you kind of sleepy.";

            //Space Room
            SpaceRoom.name = "Space Room";
            SpaceRoom.x = 1;
            SpaceRoom.y = 2;
            SpaceRoom.description = "The walls of this room have a strange torn up space themed wallpaper. It looks almost like it was a child's bedroom.";

            //Purple Room
            PurpleRoom.name = "Purple Room";
            PurpleRoom.x = 2;
            PurpleRoom.y = 1;
            PurpleRoom.description = "This room is purple. Not sure how that knowledge will help you on your adventure... but oh well.";

            //Guitar Room
            GuitarRoom.name = "Guitar Room";
            GuitarRoom.x = 2;
            GuitarRoom.y = 3;
            GuitarRoom.description = "Guitars line the walls and there's a storage trunk in one corner.";
            GuitarRoom.chest = GuitarChest;
            if (!GuitarChest.added)
            {
                GuitarChest.chestLoot.Add(SetItems.Guitar);
                GuitarChest.added = true;
            }
            //Crumpling Room
            CrumplingRoom.name = "Crumbling Room";
            CrumplingRoom.x = 1;
            CrumplingRoom.y = 3;
            CrumplingRoom.description = "The ceiling looks like it is about to fall in.";

            //Leather Room
            LeatherRoom.name = "Leather Room";
            LeatherRoom.x = 0;
            LeatherRoom.y = 3;
            LeatherRoom.description = "The entire room is lined with leather. The only parts of the entire room without leather are the doors.";
            if(LeatherRoom.monsterAdded == false)
            {
                LeatherRoom.monsters.Add(SetEntities.PossessedCow);
                LeatherRoom.monsterAdded = true;
            }


            //Cake Room
            CakeRoom.name = "Cake Room";
            CakeRoom.x = 3;
            CakeRoom.y = 3;
            CakeRoom.description = "There is a cake cemented to the floor of the room. It looks like it is made out of really well painted stone.";

            //Sun Room
            SunRoom.name = "Sun Room";
            SunRoom.x = 3;
            SunRoom.y = 1;
            SunRoom.description = "There are paintings of the sun laying all over the room. The paintings depict the sun in a strange way. It's almost as if whoever painted these had never seen the actual sun.";

            //Bloody Room
            BloodyRoom.name = "Bloody Room";
            BloodyRoom.x = 3;
            BloodyRoom.y = 2;
            BloodyRoom.description = "Blood is splattered all over the walls of this room and you see a dark figure moving around quickly.";
            if(BloodyRoom.monsterAdded == false)
            {
                BloodyRoom.monsters.Add(SetEntities.Vampire);
                BloodyRoom.monsterAdded = true;
            }

            //Torn Up Room
            TornUpRoom.name = "Torn Up Room";
            TornUpRoom.x = 3;
            TornUpRoom.y = 0;
            TornUpRoom.description = "It looks like an animal has come through this room and torn it apart. All of the furniture is destroyed and the walls has claw marks on them.";

            //Ballet Room
            BalletRoom.name = "Ballet Room";
            BalletRoom.x = 0;
            BalletRoom.y = 4;
            BalletRoom.description = "There are old ballet shoes and clothing on the floor. It looks like it was some sort of dance studio in the past.";

            //Tiger Room
            TigerRoom.name = "Tiger Room";
            TigerRoom.x = 2;
            TigerRoom.y = 4;
            TigerRoom.description = "There is a tiger in the corner of the room. It looks as if it was raised in a cage but has broken out.";
            if(TigerRoom.monsterAdded == false)
            {
                TigerRoom.monsters.Add(SetEntities.Tiger);
                TigerRoom.monsterAdded = true;
            }

            //Golden Room
            GoldenRoom.name = "Golden Room";
            GoldenRoom.x = 1;
            GoldenRoom.y = 4;
            GoldenRoom.description = "The room is made of pure gold... or is that just paint?";

            //Bug Room
            BugRoom.name = "Bug Room";
            BugRoom.x = 3;
            BugRoom.y = 4;
            BugRoom.description = "The room is full of spooky and scary bugs.";

            //Plane Room
            PlaneRoom.name = "Plane Room";
            PlaneRoom.x = 4;
            PlaneRoom.y = 4;
            PlaneRoom.description = "There are paintings of planes all over the room. In total you count about 21 of them.";

            //Radio Room
            RadioRoom.name = "Radio Room";
            RadioRoom.x = 4;
            RadioRoom.y = 3;
            if(SetEntities.Solix.alive == false)
            {
                RadioRoom.description = "There is a radio playing the weather station sitting in the corner. The forecast is rain all week.";
            }else
            {
                RadioRoom.description = "There is a radio playing the weather station sitting in the corner. The forecast is sunny skies all week.";
            }

            //Library Room
            LibraryRoom.name = "Library Room";
            LibraryRoom.x = 4;
            LibraryRoom.y = 2;
            LibraryRoom.description = "There are tons of bookshelves in this room full of all genres of book.";

            //Cloud Room
            CloudRoom.name = "Cloud Room";
            CloudRoom.x = 4;
            CloudRoom.y = 1;
            CloudRoom.description = "There are strange cloud like substances floating around near the ceiling of this room. It looks like it could start storming at any minute.";

            //Moon Room
            MoonRoom.name = "Moon Room";
            MoonRoom.x = 4;
            MoonRoom.y = 0;
            MoonRoom.description = "There are weird moon cutouts all over this room. It looks like they were going to be hung to the ceiling.";

            //-------------------Second Floor-------------------

            //Wet Room
            WetRoom.name = "Wet Room";
            WetRoom.x = 2;
            WetRoom.y = 2;
            WetRoom.z = 2;
            WetRoom.description = "The floor is wet and it almost looks like it had been raining earlier.";
            WetRoom.canGoDown = true;

            //Lightning Room
            LightningRoom.name = "Lightning Room";
            LightningRoom.x = 2;
            LightningRoom.y = 3;
            LightningRoom.z = 2;
            LightningRoom.description = "The room is full miniature lightning bolts. You feel like you could harness the power of the lightning if you had something to hold it in.";
            LightningRoom.monsters.Add(SetEntities.StormCloud);

            //Class Room
            ClassRoom.name = "Class Room";
            ClassRoom.x = 3;
            ClassRoom.y = 2;
            ClassRoom.z = 2;
            ClassRoom.description = "There are old desks strewn throughout the room and an old chalkboard is lying on the floor. The words \"The mitochondria is the powerhouse of the cell\" are written on the chalkboard.";

            //--------------------BOSS ROOMS---------------------
            //Solix Room
            SolixRoom.name = "Blinding Room";
            SolixRoom.x = 2;
            SolixRoom.y = 2;
            if (Program.player.currentQuest == Quests.SetQuests.FindChild && Program.player.Level >= 2)
            {
                if (SolixRoom.monsterAdded == false)
                {
                    SolixRoom.monsters.Add(SetEntities.Solix);
                    SolixRoom.monsterAdded = true;
                }
                SolixRoom.description = "There is an extremely bright figure in the middle of the room. Behind it is a child that looks terrified. It is most likely the child who lived in the space room.";
            } else if (SetEntities.Solix.alive == false && Quests.SetQuests.FindChild.completed == false)
            {
                SolixRoom.description = "The light goes out and you see the child standing in the back of the room.";
            } else if (SetEntities.Solix.alive == false && Quests.SetQuests.FindChild.completed == true)
            {
                SolixRoom.description = "The child runs up to you and explains that the evil bright creature snatched him out of his room. He said that he has three siblings who were also taken by strange creatures. There are stairs that are blocked off by wood that can be easily broken.";
                SolixRoom.canGoUp = true;
            }
            else if (Program.player.currentQuest != Quests.SetQuests.FindChild && Program.player.Level >= 2)
            {
                SolixRoom.description = "You can now see that there is a child standing in the back of the room behind the very bright creature. You wonder what the child is doing there but are still not ready to fight the enemy.";
            }
            else
            {
                SolixRoom.description = "You are unable to see anything in the room due to an extemely bright figure in the middle of the room. You figure that if you came back when you were more powerful you would be able to do something.";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarksReachRemake.Items;
using DarksReachRemake.Movement;
using DarksReachRemake.Quests;
using DarksReachRemake.Movement.Rooms;
using DarksReachRemake.Magic;
namespace DarksReachRemake
{
    public class Player : Entity
    {
        private Random r = new Random();
        private Location[] startingRooms = new Location[3];
        public Movement.Location Location { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int maxHealth { get; private set; }
        new public int health { get; set; }
        public List<Item> Inventory = new List<Item>();
        public int strength { get; set; }
        public int vitality { get; set; }
        public int wisdom { get; set; }
        public Item equippedWeapon { get; set; }
        new public int damage { get; private set; }
        public int totalDamage { get; set; }
        public int mana { get; set; }
        public int z { get; set; }
        public bool levelingUp { get; set; }
        public int maxMana { get; private set; }
        public List<Spell> spellBook = new List<Spell>();
        public bool monsteredRoom { get; set; }
        public int SkillPoints { get; set; }
        public int Level { get; set; }
        public Quest currentQuest { get; set; }
        public int xp { get; set; }
        public Player()
        {
            alive = true;
            currentQuest = null;
            GiveItem(SetItems.Stick);
            Level = 1;
            strength = 0;
            vitality = 0;
            wisdom = 0;
            xp = 0;
            maxHealth = 15;
            health = maxHealth;
            name = "Player";
            equippedWeapon = SetItems.Stick;
            damage = 1;
            totalDamage = 2;
            player = true;
            maxMana = 10;
            mana = maxMana;
            spellBook.Add(Magic.SetSpells.minorHealing);
            spellBook.Add(Magic.SetSpells.inflictWounds);
            x = 0;
            y = 0;
            z = 1;
        }
        public void Move(Location.Direction d)
        {
            
            switch (d)
            {
                case Location.Direction.North:
                    y++;
                    break;
                case Location.Direction.South:
                    y--;
                    break;
                case Location.Direction.West:
                    x--;
                    break;
                case Location.Direction.East:
                    x++;
                    break;
                case Location.Direction.Up:
                    z++;
                    break;
                case Location.Direction.Down:
                    z--;
                    break;
                default:
                    break;
            }
            SetRooms.FirstChestRoom.checkRoom();
            SetRooms.StartingRoom.checkRoom();
            SetRooms.FirstMonsterRoom.checkRoom();
            SetRooms.DarkStatueRoom.checkRoom();
            SetRooms.PartyRoom.checkRoom();
            SetRooms.RestRoom.checkRoom();
            SetRooms.SpaceRoom.checkRoom();
            SetRooms.SmallRoom.checkRoom();
            SetRooms.PurpleRoom.checkRoom();
            SetRooms.GuitarRoom.checkRoom();
            SetRooms.CrumplingRoom.checkRoom();
            SetRooms.LeatherRoom.checkRoom();
            SetRooms.CakeRoom.checkRoom();
            SetRooms.SunRoom.checkRoom();
            SetRooms.BloodyRoom.checkRoom();
            SetRooms.TornUpRoom.checkRoom();
            SetRooms.BalletRoom.checkRoom();
            SetRooms.TigerRoom.checkRoom();
            SetRooms.GoldenRoom.checkRoom();
            SetRooms.BugRoom.checkRoom();
            SetRooms.PlaneRoom.checkRoom();
            SetRooms.SolixRoom.checkRoom();
            SetRooms.RadioRoom.checkRoom();
            SetRooms.LibraryRoom.checkRoom();
            SetRooms.MoonRoom.checkRoom();
            SetRooms.CloudRoom.checkRoom();
            SetRooms.WetRoom.checkRoom();
            SetRooms.LightningRoom.checkRoom();
            SetRooms.ClassRoom.checkRoom();


            if (Location.realPlace == false)
            {
                if(d == Location.Direction.North)
                {
                    y--;
                    System.Windows.Forms.MessageBox.Show("There is not a room in that direction!", "Error");

                }
                if (d == Location.Direction.South)
                {
                    y++;
                    System.Windows.Forms.MessageBox.Show("There is not a room in that direction!", "Error");

                }
                if (d == Location.Direction.East)
                {
                    x--;
                    System.Windows.Forms.MessageBox.Show("There is not a room in that direction!", "Error");

                }
                if (d == Location.Direction.West)
                {
                    x++;
                    System.Windows.Forms.MessageBox.Show("There is not a room in that direction!", "Error");
                }
                if(d == Location.Direction.Up)
                {
                    z--;
                    System.Windows.Forms.MessageBox.Show("There is not a room in that direction!", "Error");
                }
                if(d == Location.Direction.Down)
                {
                    z++;
                    System.Windows.Forms.MessageBox.Show("There is not a room in that direction!", "Error");
                }
            }

            Location.realPlace = false;
        }
        public void reset()
        {
            startingRooms[0] = Movement.Rooms.SetRooms.StartingRoom;
            Inventory.Clear();
            GiveItem(SetItems.Stick);
            maxHealth = 15;
            health = maxHealth;
            name = "Player";
            equippedWeapon = SetItems.Stick;
            GiveItem(SetItems.SmallHealingPotion);
            damage = 1;
            totalDamage = 2;
            player = true;
            maxMana = 10;
            strength = 0;
            vitality = 0;
            wisdom = 0;
            mana = maxMana;
            //Location = startingRooms[r.Next(0,startingRooms.Length)];
            Location = startingRooms[0];
            x = Location.x;
            y = Location.y;
        }
        public void GiveItem(Item i)
        {
            if (Inventory.Contains(i))
            {
                if (i.weapon)
                {
                    
                }else
                {
                    i.amount++;
                }
            }
            else
            {
                Inventory.Add(i);
                i.amount = 1;
            }
        }
        public void RemoveItem(Item i)
        {
            if (Inventory.Contains(i))
            {
                i.amount--;
                if(i.amount == 0)
                {
                    Inventory.Remove(i);
                }
            }else
            {
                Inventory.Add(i);
                i.amount = 1;
            }
        }
        public void LevelUp()
        {
            if (Level == 1)
            {
                if (xp >= 50)
                {
                    LevelUpForReal();
                }
            }
            if (Level == 2)
            {
                if (xp >= 125)
                {
                    LevelUpForReal();
                }
            }
            if (Level == 3)
            {
                if (xp >= 280)
                {
                    LevelUpForReal();
                }
            }
        }
        void LevelUpForReal()
        {
            
            SkillPoints += 5;
            levelingUp = true;
            mana = maxMana;
            health = maxHealth;
            Level++;
            if (Level == 3)
            {
                SetSpells.burn.Learn();
            }
        }
        public void Hurt(int damageAmount)
        {          
            health -= damageAmount;
            if(health <= 0)
            {
                health = 0;
            }
        }
        public void ConsumeMana(Spell s)
        {
            if(mana - s.cost < 0)
            {
                System.Windows.Forms.MessageBox.Show("You do not have enough mana to cast this spell!");
            }
            else
            {
                mana -= s.cost;
            }
        }
        public void HealHealth(int healAmount)
        {
            health += healAmount;
            
            if (health > maxHealth)
            {
                health = maxHealth;
            }

        }

        public void HealMana(int manaHealAmount)
        {
            mana += manaHealAmount;
            if(mana > maxMana)
            {
                mana = maxMana;
            }
        }
        public void Update()
        {
            damage = 1 + strength;
            maxMana = 10 + wisdom;
            totalDamage = equippedWeapon.damage + damage;
            maxHealth = 15 + vitality;
        }
        public void FullyHeal()
        {
            health = maxHealth;
            mana = maxMana;
        }

    }
}

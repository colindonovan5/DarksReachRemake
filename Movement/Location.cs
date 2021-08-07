using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarksReachRemake.Items;
namespace DarksReachRemake.Movement
{
    public class Location
    {
        public enum Direction
        {
            North,
            East,
            South,
            West,
            Up,
            Down
        };
        public static bool realPlace { get; set; }
        public int x { get; set; }
        public string name { get; set; }
        public int y { get; set; }
        public string description { get; set; }
        public List<Monster> monsters = new List<Monster>();
        public Chest chest { get; set; }
        public bool deadRoom { get; set; }
        public bool monsterAdded { get; set; }
        public int z { get; set; }
        public bool canGoDown { get; set; }
        public bool canGoUp { get; set; }
        public Location()
        {
            canGoDown = false;
            canGoUp = false;
            z = 1;
        }
        //When a player moves, this checks if they are going into a real room or not.

        public void checkRoom()
        {
            try
            {
                if (Program.player.x == this.x && Program.player.y == this.y && Program.player.z == this.z)
                {
                    Program.player.Location = this;
                    realPlace = true;
                }
            }
            catch (Exception)
            {
                throw;
            }  
        }
    }
}

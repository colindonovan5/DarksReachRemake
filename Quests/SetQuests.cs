using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarksReachRemake.Movement;
using DarksReachRemake.Movement.Rooms;
namespace DarksReachRemake.Quests
{
    public class SetQuests : Quest
    {
        public static Quest FindChild = new Quest();

        public static void SetDefaults()
        {
            FindChild.questName = "Find The Child";
            FindChild.questDescription = "Find the child that lived in the space room.";
            FindChild.xpGained = 50;
            if (Entities.SetEntities.Solix.alive)
            {
                FindChild.finalDestination = null;
            }else
            {
                FindChild.finalDestination = SetRooms.SolixRoom;
            }
        }
    }
}

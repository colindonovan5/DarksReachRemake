using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DarksReachRemake.Movement;
using System.Threading.Tasks;

namespace DarksReachRemake.Quests
{
    public class Quest
    {
        public int xpGained { get; set; }
        public string questName { get; set; }
        public bool completed { get; set; }
        public string questDescription { get; set; }
        public Location finalDestination { get; set; }
        public void Complete(Player p)
        {
            p.xp += xpGained;
            p.LevelUp();
            completed = true;
            p.currentQuest = null;
        }
        public void GiveQuest(Player p)
        {
            if (completed)
            {
                System.Windows.Forms.MessageBox.Show("You already finished this quest!", "Error");
            }else if(p.currentQuest == this)
            {
                System.Windows.Forms.MessageBox.Show("This is already your active quest!", "Error");
            }else if(p.currentQuest != this && p.currentQuest == null)
            {
                p.currentQuest = this;
            }else if(p.currentQuest != this && p.currentQuest != null)
            {
                if (System.Windows.Forms.MessageBox.Show("This will reset all progress on your current quest. Are you sure you want to accept a new quest?", "WARNING", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {

                }else
                {
                    p.currentQuest = this;
                }
            }else
            {
                System.Windows.Forms.MessageBox.Show("An error has occured!", "Error");
            }
        }
    }

}

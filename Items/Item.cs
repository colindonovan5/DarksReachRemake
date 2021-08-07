using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarksReachRemake
{
    public class Item
    {
        public string name { get; set; }
        public int amount { get; set; }
        public bool weapon { get; set; }
        public bool potion { get; set; }
        public bool magic { get; set; }
        public bool equipped { get; set; }
        public bool misc { get; set; }
        public int healingAmount { get; set; }
        public int maxStack { get; set; }
        public int damage { get; set; }
        public string Display
        {
            get
            {
                if (weapon)
                {
                    return string.Format("{0} {1} - Damage: {2}", amount, name, damage);
                }else if (potion)
                {
                    return string.Format("{0} {1} - Heals {2} HP", amount, name, healingAmount);

                }
                else
                {
                    return string.Format("{0} {1}", amount, name);

                }
            }
            private set
            {
                Display = value;
            }
        }
        public virtual void SetDefaults()
        {

        }
        public void equip()
        {
            if (weapon)
            {
                if (Program.player.equippedWeapon != this)
                {
                    Program.player.equippedWeapon = this;
                    MessageBox.Show("You have equipped the " + name);
                    
                }
                else
                {
                    MessageBox.Show("You already have this equipped!");
                }
            }
            else
            {
                MessageBox.Show("You cannot equip something that isn't a weapon!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarksReachRemake
{
    public class Weapon : Item
    {
        public Weapon()
        {
            weapon = true;
            amount = 1;
            maxStack = 1;
        }
    }
}

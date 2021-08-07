using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarksReachRemake
{
    public class Entity
    {
        public bool monster { get; set; }
        public bool boss { get; set; }
        public bool player { get; set; }
        public int damage { get; set; }
        public int health { get; set; }
        public string name { get; set; }
        public bool alive { get; set; }
    }
}

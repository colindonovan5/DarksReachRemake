using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarksReachRemake.Magic
{
    public class SetSpells : Spell
    {
        public static HealingSpell minorHealing = new HealingSpell();
        public static CombatSpell inflictWounds = new CombatSpell();
        public static FireSpell burn = new FireSpell();

        public static void SetDefaults()
        {
            //Minor Healing 

            minorHealing.name = "Minor Healing";
            minorHealing.cost = 5;
            minorHealing.healingAmount = 8;

            //Inflict Wounds

            inflictWounds.name = "Inflict Wounds";
            inflictWounds.cost = 5;
            inflictWounds.damage = 7;

            //Burn

            burn.name = "Burn";
            burn.cost = 10;
            burn.damage = 8;
            burn.burnChance = 3;
           
        }
    }
}

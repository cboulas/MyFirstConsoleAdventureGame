using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAdventureGame.classes.weapons
{
    public class sword : Weapon
    {
        public sword() : base("Sword", new Range(2, 10))
        {
        }
    }
}

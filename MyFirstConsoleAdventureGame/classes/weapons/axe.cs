using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAdventureGame.classes.weapons
{
    public class axe : Weapon
    {
        public axe() : base("Axe", new Range(5, 8))
        {
        }
    }
}

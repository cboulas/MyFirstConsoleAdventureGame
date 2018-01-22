using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstConsoleAdventureGame.classes.weapons
{
    public static class enumerations
    {
        public static Dictionary<string, Weapon> weapons_enum = new Dictionary<string, Weapon>()
        {
            {"sword", new sword()},
            {"axe", new axe()}
        };
    }

    public static class methods
    {
        public static Weapon getWeapon(string name)
        {
            if (weapons.enumerations.weapons_enum.ContainsKey(name))
                return weapons.enumerations.weapons_enum.First(k => k.Key.Equals(name)).Value;

            return new Weapon("Unamed", new Range(1, 3));
        }
    }

    public class Weapon
    {
        public readonly string name;
        public readonly Range Damages;

        public Weapon(string _name, Range _damage)
        {
            name = _name;
            Damages = _damage;
        }

        protected Weapon()
        {
            throw new Exception("Do not implement");
        }
    }
}
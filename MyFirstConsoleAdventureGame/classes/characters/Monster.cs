using MyFirstConsoleAdventureGame.classes.weapons;

namespace MyFirstConsoleAdventureGame.classes.characters
{
    class Monster : Character
    {

        public Monster(string _name, int _hitPoints, Weapon _weapon)
        {
            name = _name;
            weapon = _weapon;

            hitPoints = _hitPoints;
        }



    }
}
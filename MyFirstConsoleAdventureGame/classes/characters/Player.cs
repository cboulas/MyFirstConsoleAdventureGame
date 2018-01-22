using MyFirstConsoleAdventureGame.classes.weapons;

namespace MyFirstConsoleAdventureGame.classes.characters
{
    class Player : Character
    {
        
        public Player(string _name, int _hitPoints, Weapon _weapon)
        {
            name = _name;
            hitPoints = _hitPoints;
            weapon = _weapon;
        }
    }

}
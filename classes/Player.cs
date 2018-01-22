namespace ConsoleAdventureGame
{
    class Player : Character
    {
        
        public Player(string name, int hitPoints, Weapon weapon, int minDamage, int maxDamage)
        {
            _name = name;
            _hitPoints = hitPoints;
            _weapon = weapon;
            _minDamage = weapon.minDamage;
            _maxDamage = weapon.maxDamage;
        }
    }

}
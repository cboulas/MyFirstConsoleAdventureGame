namespace ConsoleAdventureGame
{
    class Player : Character
    {
        public Player(string name, int hitPoints, string weapon)
        {
            _name = name;
            _hitPoints = hitPoints;
            _weapon = weapon;
        }
    }

}

namespace ConsoleAdventureGame
{
    class Character
    {
        protected string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        protected int _hitPoints;
        public int hitPoints
        {
            get { return _hitPoints; }
            set { _hitPoints = value; }
        }

        protected string _weapon;
        public string weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }

        public void PrintInfo()
        {
            System.Console.WriteLine($"Character name: {_name}");
            System.Console.WriteLine($"Character hitpoints: {_hitPoints}");
            System.Console.WriteLine($"Current weapon: {_weapon}");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.ReadKey();
        }
    }
}

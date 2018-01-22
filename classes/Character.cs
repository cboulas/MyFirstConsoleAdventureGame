
namespace ConsoleAdventureGame
{
    class Character
    {
        System.Random random = new System.Random();
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

        protected Weapon _weapon;
        public Weapon weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }

        protected int _minDamage;
        public int minDamage
        {
            get { return _minDamage;}
            set { _minDamage = value;}
        }

        protected int _maxDamage;
        public int maxDamage
        {
            get { return _maxDamage;}
            set { _maxDamage = value;}
        }
        
        


        public int AttackDamage()
        {
            return random.Next(_weapon.minDamage, _weapon.maxDamage);
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

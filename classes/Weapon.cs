namespace ConsoleAdventureGame
{
    class Weapon
    {
        private string _name;
        public string name
        {
            get { return _name;}
            set { _name = value;}
        }
        
        private int _minDamage;
        public int minDamage
        {
            get { return _minDamage;}
            set { _minDamage = value;}
        }
        
        private int _maxDamage;
        public int maxDamage
        {
            get { return _maxDamage;}
            set {_maxDamage = value;}
        }
        

        public Weapon(string name, int minDamage, int maxDamage)
    {
        _name = name;
        _minDamage = minDamage;
        _maxDamage = maxDamage;
    }
    }
}
class Character
{
    string _name;
    int _hitPoints;
    string _weapon;

    public Character(string name, int hitPoints, string weapon)
    {
        _name = name;
        _hitPoints = hitPoints;
        _weapon = weapon;
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
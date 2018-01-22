
using MyFirstConsoleAdventureGame.classes.weapons;

namespace MyFirstConsoleAdventureGame.classes.characters
{
    class Character
    {
        public string name { get; set; }
        public Weapon weapon { get; set; }
        public int hitPoints { get; set; }

        public int AttackDamage()
        {
            System.Random random = new System.Random();

            return random.Next(weapon.Damages.minDamage, weapon.Damages.maxDamage);
        }

        public void PrintInfo()
        {
            System.Console.WriteLine($"Character name: {name}");
            System.Console.WriteLine($"Character hitpoints: {hitPoints}");
            System.Console.WriteLine($"Current weapon: {weapon.name}");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.ReadKey();
        }
    }
}

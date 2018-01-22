using System;

namespace ConsoleAdventureGame
{
    class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            WelcomeToTheGame();
            Player playerOne = CreateCharacter();
            Monster monster = CreateNewMonster();
            Combat newFight = new Combat(playerOne, monster);
            Console.ReadKey();
        }

        private static void WelcomeToTheGame()
        {
            Console.WriteLine("Hello, and welcome to this little game of mine.");
        }

        private static Player CreateCharacter()
        {
            Console.WriteLine("Before we get going, let's create your character");
            string name = PromptName();
            Weapon weapon = PromptWeapon();
            return new Player(name, 100, weapon, weapon.minDamage, weapon.maxDamage);
        }

        private static Monster CreateNewMonster()
        {
            string name = "Monster";
            Weapon weapon = new Weapon("axe", 5, 8);
            int hitPoints = 50;

            return new Monster(name, hitPoints, weapon);
        }

        private static Weapon PromptWeapon()
        {
            while (true)
            {
                Console.WriteLine("Do you want to use a sword or an axe?");
                var answer = Console.ReadLine();
                if (answer.ToLower().Contains("sword"))
                    return new Weapon("sword", 2, 10);
                if (answer.ToLower().Contains("axe"))
                    return new Weapon("axe", 5, 8);
            }
        }

        private static string PromptName()
        {
            Console.WriteLine("What do you want to name your character?");
            return Console.ReadLine();
        }

        
    }
}

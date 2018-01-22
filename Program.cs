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
            StartCombat(playerOne, monster);
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

        public static void StartCombat(Character characterOne, Character characterTwo)
        {
            while ((characterOne.hitPoints) > 0 && (characterTwo.hitPoints > 0))
            {
                int i = 1;
                Console.WriteLine($"****Starting Round {i}****");
                PerformCombatRound(characterOne, characterTwo);
                Console.Write($"{characterOne.name} has {characterOne.hitPoints} health left.");
                Console.WriteLine($"{characterTwo.name} has {characterTwo.hitPoints} health left.");
                Console.WriteLine();
                Console.WriteLine();
                i++;
            }

            if (characterOne.hitPoints > 0)
            {
                Console.WriteLine($"{characterOne.name} survived the fight with {characterOne.hitPoints} health left");
            }
            else if(characterTwo.hitPoints > 0)
             Console.WriteLine($"{characterTwo.name} survived the fight with {characterTwo.hitPoints} health left");
            else
                Console.WriteLine($"Both {characterOne.name} and {characterTwo.name} died.");
        }

        public static void PerformCombatRound(Character characterOne, Character characterTwo)
        {
            int characterOneDamage = characterOne.AttackDamage();
            characterTwo.hitPoints -= characterOneDamage;
            Console.WriteLine($"{characterOne.name} hits {characterTwo.name} for {characterOneDamage} damage.");

            int characterTwoDamage = characterTwo.AttackDamage();
            characterOne.hitPoints -= characterTwoDamage;
            Console.WriteLine($"{characterTwo.name} hits {characterOne.name} for {characterTwoDamage}");
        }
    }
}

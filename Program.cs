using System;

namespace ConsoleAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeToTheGame();
            Character playerOne = CreateCharacter();
            playerOne.PrintInfo();

            
            
        }

        private static void WelcomeToTheGame()
        {
            Console.WriteLine("Hello, and welcome to this little game of mine.");
            
        }

        private static Character CreateCharacter()
        {
            Console.WriteLine("Before we get going, let's create your character");

            string name = PromptName();
            string weapon = PromptWeapon();
            return new Character(name, 100, weapon);
            
            
        }

        private static string PromptWeapon()
        {
            Console.WriteLine("Do you want to use a sword or an axe?");
            while(true)
                {
                    var answer = Console.ReadLine();
                    if (answer.ToLower().Contains("sword"))
                        return "sword";
                    if (answer.ToLower().Contains("axe"))
                        return "axe";
                }
        }

        private static string PromptName()
        {
            Console.WriteLine("What do you want to name your character?");
            return Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstConsoleAdventureGame.classes;
using MyFirstConsoleAdventureGame.classes.characters;
using MyFirstConsoleAdventureGame.classes.weapons;

namespace MyFirstConsoleAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeToTheGame();
            Player playerOne = CreateCharacter();
            Monster monster = CreateNewMonster();
            Combat newFight = new Combat(playerOne, monster);
            Console.ReadKey();
        }

        private static void WelcomeToTheGame()
        {
            Console.WriteLine(Messages.getMessage(Messages.typeMessage.Welcome));
        }

        private static Player CreateCharacter()
        {
            Console.WriteLine(Messages.getMessage(Messages.typeMessage.CreateCharacter));

            return new Player(
                PromptAnswer(Messages.getMessage(Messages.typeMessage.ChooseName)),
                100,
                methods.getWeapon(PromptAnswer(Messages.getMessage(Messages.typeMessage.ChooseWeapon)))
                );
        }

        private static Monster CreateNewMonster()
        {
            return new Monster("Monster", 50, new axe());
        }

        private static Weapon PromptWeapon()
        {
            while (true)
            {
                Console.WriteLine();

                var answer = Console.ReadLine();

                if (answer.ToLower().Contains("sword"))
                    return new sword();
                if (answer.ToLower().Contains("axe"))
                    return new axe();
            }
        }

        private static string PromptAnswer(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}

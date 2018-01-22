using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAdventureGame.classes
{
    public static class Messages
    {
        public enum typeMessage
        {
            Welcome,
            CreateCharacter,
            ChooseName,
            ChooseWeapon
        }

        public static string getMessage(typeMessage t)
        {
            switch (t)
            {
                case typeMessage.Welcome:
                    return "Hello, and welcome to this little game of mine.";
                case typeMessage.CreateCharacter:
                    return "Before we get going, let's create your character.";
                case typeMessage.ChooseName:
                    return "What do you want to name your character ?";
                case typeMessage.ChooseWeapon:
                    return "Do you want to use a sword or an axe ?";
                default:
                    return string.Empty;
            }
        }
    }
}

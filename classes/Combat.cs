using System;

namespace ConsoleAdventureGame
{
    class Combat
    {
        public Combat(Character characterOne, Character characterTwo)
        {
            StartCombat(characterOne, characterTwo);
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
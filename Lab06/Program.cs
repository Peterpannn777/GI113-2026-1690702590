namespace Lab06
 /*
 * Student ID : 1690702590
 * Name       : Nattaphat Kanchanarat
 * Section    : 129c
 * No.        : 18
 * Course     : GI113 Computer Programming (GI)
 */

{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  int lives = 1;

            //if(lives == 0) // ใส่เงื่อนไขที่ต้องการเช้ค ค่าที่ได้ต้องเป็น bool (t/f)
            {
                //โค๊ดด้านในจะรันก็ต่อเมทื่อ if= true
              //  Console.WriteLine("Game Over!");
            }
            //else
            {
              //  Console.WriteLine("Keep Fighting");
            }

            // ถ้า if ทำงานเสร็จแล้ว หรือเป็ร false จะทำงานต่อมาบรรทัดด้านนอกทันที
            //Console.WriteLine("Continue Code");

            //int level = 10;

            //if (level >=10)
            {
             //   Console.WriteLine("Boss floor unlocked");
            }
           // else if (level >=5) //เงื่อนไข 2
            {
              //  Console.WriteLine("The door opens");
            }
           // else //เมือไม่ตรงเง่ื่อนไข
            {
               // Console.WriteLine("The door stays shut");
            }

            //bool isPosioned = true;

            //if (isPosioned == true)
            {
              //  Console.WriteLine("You Died");
            }
           // else if (isPosioned == false) 
            {
              //  Console.WriteLine("You Lives");
            }

            int pokemonHp = 100;
            int trainerHp = 50;
            int attack = 10;
            int pokeball = 3;

            Console.WriteLine("==== POKEMON MASTER ====");
            Console.WriteLine("Trainer vs. Wild Pokemon");
            Console.WriteLine("ACTION 1: ATTACK POKEMON");
            Console.WriteLine("ACTION 2: THROW POKEBALL");

            Console.Write("Choose your action (1-2): ");
            bool userInput = int.TryParse(Console.ReadLine(), out int choice);

            if (!userInput || choice < 1 || choice > 2)
            {
                Console.WriteLine("Invalid input, please choose a number between 1-2 only.");
            }
            else if (choice == 1) // Attack Pokemon
            {
                pokemonHp -= attack;

                if (pokemonHp <= 0)
                {
                    Console.WriteLine("The wild Pokemon fainted!");
                }
                else
                {
                    Console.WriteLine($"You attacked the wild Pokemon. Pokemon HP left: {pokemonHp}");
                }
            }
            else if (choice == 2) // Throw Pokeball
            {
                if (pokeball <= 0)
                {
                    Console.WriteLine("You do not have any Pokeballs left.");
                }
                else
                {
                    pokeball--;

                    if (pokemonHp <= 30)
                    {
                        Console.WriteLine("Congratulations! You caught the wild Pokemon!");
                    }
                    else
                    {
                        Console.WriteLine($"The Pokemon escaped! Pokeballs left: {pokeball}");
                    }
                }
            }

        }
    }
}

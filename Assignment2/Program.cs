/*
 * Student ID : 1690702590
 * Name       : Nattaphat Kanchanarat
 * Section    : 129c
 * No.        : 18
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------  ");
            Console.WriteLine("--     Welcome to the Forge      --  ");
            Console.WriteLine("-----------------------------------  ");
            Console.WriteLine("=> Iron Smelting 0.25 / Salvage 0.3  ");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)  ");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)  ");


            const int MaxBatch = 500;
            const double SmeltRate = 0.25;
            const double SavageRate = 0.3;
            const string Matetrial = "Vibra nium";
            char menu;
            double amount;
            bool result;

            Console.Write("=> Choose Menu: ");
            result = char.TryParse(Console.ReadLine(), out menu); // result true -> parse success, false -> parse not success

            Console.Write("=> How much would you like: ");
            result = double.TryParse(Console.ReadLine(), out amount);

            if(result == true && amount > 0 && amount <= MaxBatch)
            {
                if (menu == 'S' || menu == 's')
                {
                    double Ingot = amount * SmeltRate;
                    Console.WriteLine($"=>{amount} {Matetrial} Ore = {Ingot} {Matetrial} Ingot");
                }
                else if (menu == 'B' || menu == 'b')
                {
                    double Ore = amount / SavageRate;
                    Console.WriteLine($"=>{amount} {Matetrial} Ingot = {Ore.ToString("#.##")} {Matetrial} Ore");
                }
                else
                {
                    Console.WriteLine("error: menu");
                }
            }
            else
            {
                Console.WriteLine("error: amount ");
            }
        }
    }
}
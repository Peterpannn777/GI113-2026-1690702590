/*
 * Student ID : 1690702590
 * Name       : Nattaphat Kanchanarat
 * Section    : 129c
 * No.        : 18
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string WorldName = "Moonlight Trails";

            var petName = "Mochi";
            var petRarity = 'R';
            int friendshipLevel = 27;
            float snackMeter = 0.62f;
            double runningSpeed = 18.7;
            bool hasFoundTreasure = false;

            double friendshipPoints = friendshipLevel;
            int speedWithoutDecimal = (int)runningSpeed;
            int speedRounded = Convert.ToInt32(runningSpeed);

            Console.WriteLine($"+------------------------------+");
            Console.WriteLine($"|      PET PASSPORT            |");
            Console.WriteLine($"|      {WorldName}       |");
            Console.WriteLine($"+------------------------------+");
            Console.WriteLine($"Companion       : {petName}");
            Console.WriteLine($"Rarity          : {petRarity}");
            Console.WriteLine($"Friendship      : {friendshipLevel}");
            Console.WriteLine($"Snack meter     : {snackMeter}");
            Console.WriteLine($"Running speed   : {runningSpeed}");
            Console.WriteLine($"Treasure found  : {hasFoundTreasure}");
            Console.WriteLine($"+------------------------------+");
            Console.WriteLine($"DISPLAY CHECK");
            Console.WriteLine($"Friendship points : {friendshipPoints}");
            Console.WriteLine($"Speed cut down    : {speedWithoutDecimal}");
            Console.WriteLine($"Speed rounded     : {speedRounded}");
            Console.WriteLine($"+------------------------------+");
        }
    }
}

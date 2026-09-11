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
            const string GameTitle = "Mech Frontier";

            var mechName = "Aegis Runner";
            var mechClass = 'S';
            int reactorLevel = 42;
            float boostCharge = 0.85f;
            double armorIntegrity = 73.6;
            bool isMissionReady = true;

            double reactorLevelDisplay = reactorLevel;
            int armorTruncated = (int)armorIntegrity;
            int armorRounded = Convert.ToInt32(armorIntegrity);

            Console.WriteLine($"========================================");
            Console.WriteLine($"          {GameTitle} : MECH STATUS");
            Console.WriteLine($"========================================");
            Console.WriteLine($"Unit Name       : {mechName}");
            Console.WriteLine($"Combat Class    : {mechClass}");
            Console.WriteLine($"Reactor Level   : {reactorLevel}");
            Console.WriteLine($"Boost Charge    : {boostCharge}");
            Console.WriteLine($"Armor Integrity : {armorIntegrity}");
            Console.WriteLine($"Mission Ready   : {isMissionReady}");
            Console.WriteLine($"----------------------------------------");
            Console.WriteLine($"Reactor as double  : {reactorLevelDisplay}");
            Console.WriteLine($"Armor cast value   : {armorTruncated}");
            Console.WriteLine($"Armor rounded value: {armorRounded}");
            Console.WriteLine($"========================================");
        }
    }
}

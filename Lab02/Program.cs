/*
 * Student ID : 1690702590
 * Name       : Nattaphat Kanchanarat
 * Section    :129C
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power : {attackPower}");
            Console.WriteLine($"Crit Multiplier : {critMultiplier}");
            Console.WriteLine($"Is Boss : {isBoss}");
           
            Console.WriteLine();
            //คำนวนเปอร์เซ๋น
            int hpPercent = currentHp = 100 / maxHp;
            Console.WriteLine($"Hp Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();
            // ลด HP 60 หน่วย
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== Boss STATUS : AFTER DAMAGE=====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent= currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent : {hpPercent}%");
           
            string bossName = "Ignis";
            char Role = 'M'; // M role = Mage
            int level = 1;
            int maxHp = 250;
            float Power = 10f;
            double Special_Power = 20.75;
            bool isAliveS = true;









        }
    }
}

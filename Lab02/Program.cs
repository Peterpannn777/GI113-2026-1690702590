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
            Console.WriteLine($"Crit Multiplier : {critMultiplier}X");
            Console.WriteLine($"Crit Multiplier : {critMultiplier}X     ");
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

            //////// 1. อัศวินนักรบ (Knight) //////////
            string knightName = "Arthur";
            int knightLevel = 45;
            double knightMaxHp = 1250.50;
            char knightRank = 'S';
            bool knightIsShieldEquipped = true;

            Console.WriteLine($"--- Character 1: {knightName} ---");
            Console.WriteLine($"Name: {knightName}");
            Console.WriteLine($"Level: {knightLevel}");
            Console.WriteLine($"Max HP: {knightMaxHp}");
            Console.WriteLine($"Guild Rank: {knightRank}");
            Console.WriteLine($"Shield Equipped: {knightIsShieldEquipped}");
            Console.WriteLine();

            //////// 2. Character: Mage (จอมเวท) //////////
            string mageName = "Elena";
            int mageMana = 850;
            float mageSpellPower = 245.75f;
            char mageRank = 'A';
            bool mageIsStunned = false;

            Console.WriteLine($"--- Character 2: {mageName} ---");
            Console.WriteLine($"Name: {mageName}");
            Console.WriteLine($"Mana: {mageMana}");
            Console.WriteLine($"Spell Power: {mageSpellPower}");
            Console.WriteLine($"Guild Rank: {mageRank}");
            Console.WriteLine($"Is Stunned: {mageIsStunned}");
            Console.WriteLine();

            ////////3.Character: Rogue(โจร)////////
            string rogueName = "Shadow";
            float rogueSpeed = 12.5f;
            double rogueCritRate = 45.85;
            char rogueRank = 'B';
            bool rogueIsStealthed = true;

            Console.WriteLine($"--- Character 3: {rogueName} ---");
            Console.WriteLine($"Name: {rogueName}");
            Console.WriteLine($"Move Speed: {rogueSpeed}");
            Console.WriteLine($"Critical Rate: {rogueCritRate}%");
            Console.WriteLine($"Guild Rank: {rogueRank}");
            Console.WriteLine($"In Stealth: {rogueIsStealthed}");
            Console.WriteLine();

            ///////4.Character: Archer(นักธนู)///////
            string archerName = "Robin";
            int archerArrowCount = 99;
            float archerAttackRange = 35.0f;
            double archerAccuracy = 98.42;
            bool archerIsPoisonActive = false;

            Console.WriteLine($"--- Character 4: {archerName} ---");
            Console.WriteLine($"Name: {archerName}");
            Console.WriteLine($"Arrows Remaining: {archerArrowCount}");
            Console.WriteLine($"Attack Range: {archerAttackRange} meters");
            Console.WriteLine($"Accuracy: {archerAccuracy}%");
            Console.WriteLine($"Poison Coating Active: {archerIsPoisonActive}");











        }
    }
}










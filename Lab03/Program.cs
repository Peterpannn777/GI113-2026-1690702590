namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("====KIRIN SAVE CONVERT");
            Console.WriteLine($"Name: {bossName}" +
                $"\nRank: {rank}" +
                $"\nLevel: {level}" +
                $"\nMax HP: {maxHp}" +
                $"\nCurrent HP: {currentHp}" +
                $"\nAttack Power: {attackPower}" +
                $"\nCritical Multiplier: {critMultiplier}" +
                $"\nIs Boss: {isBoss}");
            //1. Implicit Conversion Int (HP) -->> Double
            Console.WriteLine("\n----IMPLICIT CONVERSION: HP as double ----");
            double currentHpDouble = currentHp;
            Console.WriteLine ($"Hp (Double): {currentHpDouble}");
            //2. Calculate Percentage 
            Console.WriteLine("\n----Exact HP percent (no integer truncation)-----");
            double hpPercentexact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"Hp Percent (Exact): {hpPercentexact}%");
            //3. Explicit float (attackPower) -->> Int
            Console.WriteLine("\n----Explicit Cast: Attack Power -> Display Int ----");
            int attackPowerInt = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackPowerInt}");
            //4. Cast vs. Convert double (critMultiplier) -->> Int
            Console.WriteLine("\n----CAST vs. CONVERT: Critical Multiplier  ----");
            int critMultiplierIntCast = (int)critMultiplier;
            int critMultiplierIntConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Critical Multiplier (int cast): {critMultiplierIntCast}");
            Console.WriteLine($"Critical Multiplier (Convert rounded): {critMultiplierIntConvert}");
        }
    }
}

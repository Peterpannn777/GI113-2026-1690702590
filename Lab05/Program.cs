namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game Title, Sub-tittle
            Console.WriteLine("==>> My GAME DEE <<==");
            Console.WriteLine("Hero vs. Monster, Fight damage calculator\n");

            // Hero stat input
            Console.WriteLine("Hero Health: ");
            bool heroHp0k = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero Attack: ");
            bool heroAtk0k = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.WriteLine("Hero Defense: ");
            bool heroDef0k = int.TryParse(Console.ReadLine(), out int heroDef);
            // Monster stat input
            Console.WriteLine("Monster Health: ");
            bool monHp0k = int.TryParse(Console.ReadLine(), out int monsterHp);
            Console.WriteLine("Monster Attack: ");
            bool monAtk0k = int.TryParse(Console.ReadLine(), out int monsterAtk);
            Console.WriteLine("Monster Defense: ");
            bool monDef0k = int.TryParse(Console.ReadLine(), out int monsterDef);


            // Input validation
            bool isHeroIntValid = heroHp0k && heroAtk0k && heroDef0k;
            bool isMonsterIntValid = monHp0k && monAtk0k && monDef0k;
            Console.WriteLine($"\nHero STATUS VALID: {isHeroIntValid}");
            Console.WriteLine($"Monster STATUS VALID: {isMonsterIntValid}");

            Console.WriteLine($"[HERO] HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
            Console.WriteLine($"[MONSTER] HP: {monsterHp}, ATK: {monsterAtk}, DEF: {monsterDef}")
            //bool allIntValid = isHeroIntValid && isMonsterIntValid;
            // ถ้าเอาแค่ชื่อ bool มาเช็คคือเช็คว่าเป๋นจริงมั้ย? แต่ถ่้าใส่ ! ด้านหลังคือตรงข้าม (จรืง -> เท็จ)

            // Compound assignment : += จำลองสถานการณ์การผู้เล่นดื่ม potion ก่อนต่อสู้
            int potionHeal = 8;
            //heroHp = heroHp + potionHeal; // แบบยาว
            heroHp += potionHeal; // แบบสั้น  ความหมายเดียวกัน นำ potion heal มา + กับ heroHp
            Console.WriteLine($"\nHero drinks a potion, healing  {potionHeal} HP. Hero HP now {heroHp} HP");

            // Artithmetic + การโจมตีธรรมดา
            int normDng = Math.Max(0, heroAtk - monsterDef); // ความแรงการโจมตีขึ้นอยู่กับค่าป้องกันของศัตรู
            Console.WriteLine($"\nNormal attacks Would deal: {normDng} DMG");

            // Precedence การโจมตีพิเศษ
            int pwrDmg = Math.Max(0, heroAtk * 2 - monsterDef); // โจมตีคูณ 2 จะใส่วงเล็กหรือไม่ก็ได้เพราะทำคูณก่อน
            Console.WriteLine($"Power attacks Would deal: {pwrDmg} DMG");

            //Random, Simeple percent chance.
            Random randomSomething = new Random();
            int roll = randomSomething.Next(1, 101); /// ต้อง+1 ค่ามากสุดเสมิ เช่นอยากได้ 100 ต้อว 101
            bool isCrit = roll <= 10; // 10% chance จาก 100
            int critDmg = normDng + Convert.ToInt32(isCrit) * normDng; // Bool 1  
            Console.WriteLine($"\nCritical hit rool : {roll} (critical: {isCrit} ");
            Console.WriteLine($"IF critical, normal attack would instead deal: {critDmg});

        }
    }
}

class Fight
{
    public int HeroHp { get; set; }

    public int HeroDamage { get; set; }
    public string HeroName { get; set; }

    public int EnemyHp { get; set; }

    public int EnemyDamage { get; set; }

    public string? EnemyName { get; set; }

    public string? SecondEnemyName { get; set; }

    public Fight(int herohp, int herodamage, string? heroname, int enemyhp, int enemydamage, string? enemyname, string secondEnemyName)
    {
        this.HeroHp = herohp;
        this.HeroDamage = herodamage;
        this.HeroName = heroname;
        this.EnemyHp = enemyhp;
        this.EnemyDamage = enemydamage;
        this.EnemyName = enemyname;
        this.SecondEnemyName = secondEnemyName;  
    }

    public void FightingWithEnemy()
    {
        Console.ReadLine();
        Console.Clear();
        Console.ForegroundColor= ConsoleColor.Blue;
        Console.WriteLine("\t\t\t\t\t\t\t-=Бой=-");
        Console.WriteLine("\t-=Для того что бы нанести урон противнику нажмите Enter, но противник также будет наносить Вам урон=-");
        Console.ResetColor();

        while (EnemyHp > 0 || HeroHp < 0)
        {

            switch (Console.ReadKey(true).Key)
            {

                case ConsoleKey.Enter:

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"\nHp у {HeroName}: {HeroHp}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"\t\t\t\t\tHp у {SecondEnemyName}: {EnemyHp}");
                    Console.ResetColor();



                    EnemyHp -= HeroDamage;
                    HeroHp -= EnemyDamage;
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.Write($"\n{HeroName} нанес: {HeroDamage}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\t\t\t\t\t{EnemyName} нанес: {EnemyDamage}\n");
                    Console.ResetColor();

                    if (EnemyHp == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t\t\t\tВы победили этот бой");
                        Console.ResetColor();
                        break;

                    }
                    if (HeroHp == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t\t\t\tВы проиграли этот бой");
                        Console.ResetColor();
                        return;
                      
                    }
                    break;




            }

        }
        Console.ReadLine();
        Console.Clear();


    }


}


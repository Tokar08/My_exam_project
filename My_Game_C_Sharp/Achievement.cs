﻿
// Достижения которые игрок получает во время игры

public class Achievement
{
    public string? Name_Of_Achievement { get; set; }

    public string? Description { get; set; }
    public DateTime? GettingTime { get; set; }

    public Achievement(string NoA, string des)
    {
        Name_Of_Achievement = NoA;
        Description = des;
    
        
    }
    public Achievement(string NoA) { Name_Of_Achievement = NoA; }
    public Achievement() { }
 

    public void AddAchievement()
    {
        Console.SetCursorPosition(0, 27);
        Console.ForegroundColor= ConsoleColor.Blue;
        Console.WriteLine($"Новое достижение получено: {Name_Of_Achievement}.\nДата и время получения: {DateTime.Now}");
        Console.ResetColor();
        
        
    }


    public void Add(Achievement ach, List<Achievement> achList) => achList.Add(ach);
    public void IsEmpy(List<Achievement> achList)
    {

        if (achList.Count == 0)
        {
            Console.WriteLine("У Вас нет еще достижений, пройдите сюжет для их получения!");

        }
        else 
        {
            Console.WriteLine("Проходя игру Вы получили следующие достижения:");

        }
    
    
    }
    public void Show(List<Achievement> achList)
    {
        foreach (Achievement a in achList)
            Console.WriteLine($"\nНазвание ачивки: {a.Name_Of_Achievement}.\nУсловие: {a.Description}.");
    }


}

public class PushAllAchievement : Achievement
{
    public PushAllAchievement() { }

    public List<Achievement> AchievementListGame = new List<Achievement>();


 
        ////Достижения пролога:
        //AchievementListGame.Add(new Achievement("Начало положено", "Пройдите пролог", DateTime.Now));

        ////Достижения Глава 1:
        //AchievementListGame.Add(new Achievement("Сухой закон", "Откажитесь от выпивки в таверне", DateTime.Now));
        //AchievementListGame.Add(new Achievement("Загадочный доктор", "Познакомьтесь с Эмилем Форсманом.", DateTime.Now));
        //AchievementListGame.Add(new Achievement("Будем знакомы", "Выберите имя для своего персонажа.", DateTime.Now));
        //AchievementListGame.Add(new Achievement("Загадочный коронер", "Познакомьтесь с Балианом Мейером.", DateTime.Now));
        //AchievementListGame.Add(new Achievement("Загадочный Преподобный", "Познакомьтесь с Роем Вильмериусом.", DateTime.Now));
        //AchievementListGame.Add(new Achievement("Первые шаги", "Пройдите 1 главу.", DateTime.Now));
        ////Достижения Глава 2:

        //AchievementListGame.Add(new Achievement("Падальщик", "Познакомьтесь с Бризгоном.", DateTime.Now));
        //AchievementListGame.Add(new Achievement("Записки Карателя", "Пройдите 2 главу.", DateTime.Now));

        ////Достижения Глава 3:
        //AchievementListGame.Add(new Achievement("Тени Прошлого", "Узнайте истории становления Эмиля, Роя и Балиана.", DateTime.Now));
        //AchievementListGame.Add(new Achievement("Наследница", "Познакомтесь с Каей.", DateTime.Now));
        //AchievementListGame.Add(new Achievement("Верный друг", "Выберите имя для своей лошади.", DateTime.Now));



        //AchievementListGame.Add(new Achievement("Работа сделана", "Пройдите игру с любым исходом.", DateTime.Now));


}



// Пример нормальной работы:
//var All_Achievemen = new PushAllAchievement();
//All_Achievemen.IsEmpy(All_Achievemen.AchievementListGame);
//All_Achievemen.IsEmpy(a.all_push.AchievementListGame);
//All_Achievemen.Show(a.all_push.AchievementListGame);




// Пример отличной работы:

//var All_Achievement = new PushAllAchievement();
//All_Achievement.IsEmpy(a.all_push.AchievementListGame);

//All_Achievement.Show(a.all_push.AchievementListGame);










//public class test2
//{
//    public void Action()
//    {

//        var a = new Achievement("Конец", "Пройдите игру", DateTime.Now);




//        a.CheckAchievement();
//        int choose = Convert.ToInt32(Console.ReadLine());
//        if (choose == 1)
//        {
//            a.CompleteAchievement();
//            a.CheckAchievement();
//        }
//        else
//            Console.WriteLine("no");


//        a.CheckAchievement();
//    }

//}

//public class Programm
//{

//    public static void Main()
//    {

//        var a = new Achievement("Начало конца", "Пройдите пролог", DateTime.Now);

//        var b = new test2();
//        b.Action();




//    }


//}

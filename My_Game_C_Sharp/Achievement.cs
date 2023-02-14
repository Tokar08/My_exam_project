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

}




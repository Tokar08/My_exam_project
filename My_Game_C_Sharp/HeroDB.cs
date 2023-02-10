

//Добавить информацию о перонаже при открытии сюжета

public class GetNames 
{
    public string? PlayerName { get; set; }
    public string? HorsName { get; set; }

    public GetNames()
    {    }

}

public class AddHeroInfo
{
    public string? Info { get; set; }
    public AddHeroInfo(string? info)
    {
        Info = info;
    }
    public void NewInfo(string new_info)
    {
        Info += new_info;
    }
    public void Show()
    {
        Console.WriteLine(Info);
    }

    public static AddHeroInfo operator +(AddHeroInfo a, AddHeroInfo b) => a + b;
    public static AddHeroInfo operator -(AddHeroInfo a, AddHeroInfo b) => a - b;

}



//Пример добавления новой информации о персонаже
//public class test
//{
//    internal AddHeroInfo asd = new AddHeroInfo("");
//    public void ShowTest1()
//    {
//        asd.NewInfo("Его зовут Вася.");




//    }

//}
//public class test2 : test
//{
//    public test zxc = new test();
//    public void ShowTest2()
//    {
//        zxc.ShowTest1();

//        asd.NewInfo("У него есть права");
//        var t = zxc.asd.Info + asd.Info;
//        Console.WriteLine(t);



//    }

//}

//public class Programm
//{

//    public static void Main()
//    {

//        var qwe = new test2();

//        qwe.ShowTest2();

//    }


//}




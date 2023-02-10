 
//Добавление и отбавления очков авторитета (исправен)
public class HonorBD
{
  public int Honor { get; set; }

    public HonorBD(int hohor) 
    {
       this.Honor = hohor;
    }

    public void AddHonor() => Honor += 10;
   
    public void RemoveHonor() => Honor -= 10;

    public bool CheckHonor(int honor)
    {
        if (Honor > honor) 
        {
            Console.WriteLine(":-)");
        }
        else
        {
            Console.WriteLine(":-(");
        }
        return true;
    }
   
    public void ShowHonor() => Console.WriteLine(Honor);
   
}


//Пример работы очков чести
//public class test
//{
//    internal HonorBD honor = new HonorBD(0);
//    public void ShowTest1()
//    {
//        int choose;
//        choose = Convert.ToInt32(Console.ReadLine());
//        if (choose == 1)
//        {
//            honor.AddHonor();

//            honor.ShowHonor();
//        }
//        else
//        {
//            honor.RemoveHonor();

//            honor.ShowHonor();
//        }

//        honor.CheckHonor(9);
//        choose = Convert.ToInt32(Console.ReadLine());
//        if (choose == 1)
//        {
//            honor.AddHonor();

//            honor.ShowHonor();
//        }
//        else
//        {
//            honor.RemoveHonor();

//            honor.ShowHonor();
//        }

//        honor.CheckHonor(9);
//        choose = Convert.ToInt32(Console.ReadLine());
//        if (choose == 1)
//        {
//            honor.AddHonor();

//            honor.ShowHonor();
//        }
//        else
//        {
//            honor.RemoveHonor();

//            honor.ShowHonor();
//        }

//        honor.CheckHonor(29);
//    }



//}
//public class test2 : test
//{
//    protected test Honor = new test();

//    public void ShowTest2()
//    {
//        Honor.ShowTest1();
//        int choose;
//        choose = Convert.ToInt32(Console.ReadLine());
//        if (choose == 1)
//        {

//            Honor.honor.AddHonor();
//            Honor.honor.ShowHonor();
//        }
//        else
//        {
//            Honor.honor.RemoveHonor();

//            Honor.honor.ShowHonor();
//        }

//        honor.CheckHonor(9);
//        choose = Convert.ToInt32(Console.ReadLine());
//        if (choose == 1)
//        {
//            Honor.honor.AddHonor();

//            Honor.honor.ShowHonor();
//        }
//        else
//        {
//            Honor.honor.RemoveHonor();

//            Honor.honor.ShowHonor();
//        }

//        honor.CheckHonor(9);
//        choose = Convert.ToInt32(Console.ReadLine());
//        if (choose == 1)
//        {
//            Honor.honor.AddHonor();

//            Honor.honor.ShowHonor();
//        }
//        else
//        {
//            Honor.honor.RemoveHonor();

//            Honor.honor.ShowHonor();
//        }
//        Honor.honor.AddHonor();
//        Honor.honor.AddHonor();
//        Honor.honor.AddHonor();
//        Honor.honor.AddHonor();
//        Honor.honor.AddHonor();
//        Honor.honor.AddHonor();
//        Honor.honor.ShowHonor();
//        Honor.honor.CheckHonor(29);
//    }

//}

//public class Programm
//{

//    public static void Main()
//    {



//        var zxc2 = new test2();

//        zxc2.ShowTest2();






//    }


//}
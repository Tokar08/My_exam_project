public class Menu 
{
    public HonorBD honor = new HonorBD(0);
    internal Music music = new Music();


    public void mainMenu()
    {
      
        music.Music_Menu();
        Game a = new Game();
        string[] menuItems = new string[] { "Новая игра", "Достижения", "Выход" };
        int active_menu = 0;



        while (true)
        {
         
            int x = 50; int y = 10;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < menuItems.Length; i++)
            {
            
                if (i == active_menu)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                    Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(x, y++);
                Console.WriteLine(menuItems[i]);
            }



            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.DownArrow:
                    if (active_menu < menuItems.Length - 1)
                    {
                        active_menu++;
                    }
                    continue;
                case ConsoleKey.UpArrow:
                    if (active_menu > 0)
                    {
                        active_menu--;
                    }
                    continue;
                case ConsoleKey.Enter:
                    switch (active_menu)
                    {
                        case 0:
                            Console.Clear();
                            
                         
                            a.AllChapters();
                            Console.Clear();
                            continue;
                        case 1:
                            Console.Clear();
                           
                            a.AllAchievement();

                            Console.ReadLine();
                            Console.Clear();
                            continue;



                        case 2:


                            return;

                    }
                    break;



            }

            break;
        }

    }
    public void ChooseLvl()
    {


        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(43, 7);
        Console.WriteLine("-=Выберите уровень игры=-");
        string[] menuItems = new string[] { "Легкий", "Средний", "Тяжелый" };
        int active_menu = 0;



        while (true)
        {
            music.Music_Sound();
            int x = 50; int y = 10;
            Console.SetCursorPosition(x, y);

            for (int i = 0; i < menuItems.Length; i++)
            {

                if (i == active_menu)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                    Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(x, y++);
                Console.WriteLine(menuItems[i]);
            }



            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.DownArrow:
                    if (active_menu < menuItems.Length - 1)
                    {
                        active_menu++;
                    }
                    continue;
                case ConsoleKey.UpArrow:
                    if (active_menu > 0)
                    {
                        active_menu--;
                    }
                    continue;
                case ConsoleKey.Enter:
                    switch (active_menu)
                    {
                        case 0:
                            honor.AddHonor();
                            honor.AddHonor();
                            Console.WriteLine(honor.Honor);
                            Console.Clear();
                            Console.ResetColor();

                            break;
                        case 1:
                            honor.AddHonor();
                            honor.RemoveHonor();
                            Console.WriteLine(honor.Honor);
                            Console.Clear();
                            Console.ResetColor();
                            break;




                        case 2:

                            Console.Clear();
                            honor.RemoveHonor();
                            honor.RemoveHonor();
                            Console.WriteLine(honor.Honor);
                            Console.Clear();
                            Console.ResetColor();
                            break;


                    }
                    break;



            }

            break;
        }



    }



}
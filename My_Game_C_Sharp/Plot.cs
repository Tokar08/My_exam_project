

public class Prologue : Menu
{

    public Achievement ach = new Achievement("Начало положено");
    public Achievement ach1 =  new Achievement("Начало положено", "Пройдите пролог");
    public PushAllAchievement all_push = new PushAllAchievement();

    public string[] arrayOfPrologue = new string[]
    {
    "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\1_Prologue_part_1.txt",
    "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\1_Prologue_part_2.txt",
    "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\1_Prologue_part_3.txt",
     };
  
    public void Part_1()
    {
        ChooseLvl();
        music.Sound_Prologue();
        music.Prologue_music();
   
        
        string? line;
        StreamReader sr = new StreamReader(arrayOfPrologue[0]);
    
        line = sr.ReadLine();
      
        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.ReadLine();
        Console.Clear();
    }
    public void Part_2()
    {
        string? line;
        StreamReader sr = new StreamReader(arrayOfPrologue[1]);

        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
   

        Console.ReadLine();
        Console.Clear();
    
    }
    public void Part_3()
    {
        string? line;
        StreamReader sr = new StreamReader(arrayOfPrologue[2]);

        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        ach.AddAchievement();
        all_push.AchievementListGame.Add(ach1);
        Console.ReadLine();
        Console.Clear();
    }
   
}

public class Chapter_1 : Prologue
{

    internal Music music = new Music();
    public  static GetNames getName = new GetNames();

    public Achievement alcohol_law = new Achievement("Сухой закон");
    public Achievement alcohol = new Achievement("Сухой закон", "Откажитесь от выпивки в таверне");

    public Achievement meet_with_doctor = new Achievement("Загадочный доктор");
    public Achievement meet_w_d = new Achievement("Загадочный доктор", "Познакомьтесь с Эмилем Форсманом");

    public Achievement stranger = new Achievement("Будем знакомы");
    public Achievement stranger_ach = new Achievement("Будем знакомы", "Выберите имя для своего персонажа");

    public Achievement meeting_with_coroner = new Achievement("Загадочный коронер");        
    public Achievement meet_with_c = new Achievement("Загадочный коронер", "Познакомьтесь с Балианом Мейером");

    public Achievement meeting_with_P = new Achievement("Загадочный Преподобный");
    public Achievement meet_with_p = new Achievement("Загадочный Преподобный", "Познакомьтесь с Роем Вильмериусом");

    public Achievement End_Chapter_1 = new Achievement("Первые шаги");
    public Achievement end_chapter_1 = new Achievement("Первые шаги", "Пройдите 1 главу");

    public string[] arrayOfChapter1 = new string[]
   {
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_in_a_tavern.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_in_a_tavern_2.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_in_a_tavern_3.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_in_a_taver_aggressive_behavior.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_in_a_tavern_normal_behavior.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_main_square.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_dialogue_with_Forsman_1.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_dialogue_with_Forsman_2.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_sewerage.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_dead.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_Fjokes.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_unpleasant_meeting_1.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_unpleasant_meeting_2.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_unpleasant_meeting_3.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_unpleasant_meeting_aggressive_behavior.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_unpleasant_meeting_normal_behavior.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_unpleasant_meeting_anwser_of_P.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_conclusions_answer_1.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_conclusions_answer_2.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_conclusions_answer_3.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_last_dialogue_with_Forsman.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\2_Chapter_1_detail_of_history.txt",
};


    public void In_a_tavern_1()
    {
        music.Sound_Chapter_1();
        music.Chapter_1_normal_music();
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter1[0]);

        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
     
    }

    public void Choose_of_drinking()
    {
       
        string[] menuItems = new string[] { "1 - Здравствуйте, бокал белого вина.\t", "2 - Здравствуйте, откажусь от выпивки." };
        int active_menu = 0;



        while (true)
        {
            int x = 15; int y = 10;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < menuItems.Length; i++)
            {

                if (i == active_menu)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                    Console.ForegroundColor = ConsoleColor.White;

                Console.Write(menuItems[i]);

            }



            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.RightArrow:
                    if (active_menu < menuItems.Length - 1)
                    {
                        active_menu++;
                    }
                    continue;
                case ConsoleKey.LeftArrow:
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
                            Console.Clear();
                            Console.ResetColor();

                            break;
                        case 1:

                            honor.AddHonor();
                            alcohol_law.AddAchievement();
                            all_push.AchievementListGame.Add(alcohol);
                            Thread.Sleep(1500);
                            Console.Clear();
                            break;



                    }
                    break;



            }
            break;
        }
      
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter1[1]);

        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.ReadLine();
        Console.Clear();

    }
    public void In_a_tavern_2()
    {

        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter1[2]);

        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
       

    }
    public void Choose_of_behavior() 
    {
     
        string[] menuItems = new string[] { "1 - Надавить на корчмаря.\t", "2 - Спросить, как добраться до больницы." };
        int active_menu = 0;



        while (true)
        {
            int x = 15; int y = 10;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < menuItems.Length; i++)
            {

                if (i == active_menu)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                    Console.ForegroundColor = ConsoleColor.White;

                Console.Write(menuItems[i]);

            }



            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.RightArrow:
                    if (active_menu < menuItems.Length - 1)
                    {
                        active_menu++;
                    }
                    continue;
                case ConsoleKey.LeftArrow:
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
                            music.Chapter_1_aggresive_music();
                            honor.RemoveHonor();
                            string? line;
                            StreamReader sr = new StreamReader(arrayOfChapter1[3]);

                            line = sr.ReadLine();

                            while (line != null)
                            {
                                Console.WriteLine(line);
                                line = sr.ReadLine();
                            }
                            sr.Close();
                            Console.ReadLine();
                            Console.Clear();

                            string? lines;
                            StreamReader srs = new StreamReader(arrayOfChapter1[4]);

                            lines = srs.ReadLine();

                            while (lines != null)
                            {
                                Console.WriteLine(lines);
                                lines = srs.ReadLine();
                            }
                            srs.Close();
                            Console.Clear();
                            Console.ResetColor();

                            break;
                        case 1:

                            honor.AddHonor();
                            Console.Clear();
                            Console.ResetColor();
                            break;

                    }
                    break;
                    


            }
            break;
        }
        string? linew;
        StreamReader srw = new StreamReader(arrayOfChapter1[4]);

        linew = srw.ReadLine();

        while (linew != null)
        {
            Console.WriteLine(linew);
            linew = srw.ReadLine();
        }
        srw.Close();

        Console.ReadLine();
        Console.Clear();

    }
    public void Main_square() 
    {
       
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter1[5]);
        music.Chapter_1_Main_square();
        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        meet_with_doctor.AddAchievement();
        all_push.AchievementListGame.Add(meet_w_d);
        Console.ReadLine();
        Console.Clear();


    }
    public void Dialogue_with_Forsman_1()
    {
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter1[6]);
        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.WriteLine("\n*Введите имя Вашего детектива, оно останется с Вами до окончания игры:");
        getName.PlayerName = Console.ReadLine();
        Console.WriteLine($"\n- Хорошо, {getName.PlayerName}, думаю мне представляться не имеет смысла. Что бы Вы хотели от меня услышать или чем я могу Вам помочь?");
        stranger.AddAchievement();
        all_push.AchievementListGame.Add(stranger_ach);
        Console.ReadLine();
        Console.Clear();




    }
    public void Dialogue_with_Forsman_2()
    {
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter1[7]);
        music.Chapter_1_Main_square();
        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.ReadLine();
        Console.Clear();


    }
    public void Sewerage()
    {
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter1[8]);
        music.Chapter_1_severage();
        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.ReadLine();
        Console.Clear();


    }
    public void Dead()
    {
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter1[9]);
        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.ReadLine();
        Console.Clear();


    }
    public void Forsmans_jokes()
    {
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter1[10]);
        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.ReadLine();
        Console.Clear();


    }
    public void Unpleasant_meeting_1() 
    {
        music.Chapter_1_Unpleasant_meeting_music();
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter1[11]);
        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.WriteLine($"\n-Я бы не разбрасывался словами... {getName.PlayerName}, познакомитесь наш коронер Балиан. Только зачем ты сегодня пришел сегодня,\nу тебя же отпуск или я ошибаюсь?");
        meeting_with_coroner.AddAchievement();
        all_push.AchievementListGame.Add(meet_with_c);
        Console.ReadLine();
        Console.Clear();
    }
    public void Unpleasant_meeting_2()
    {
        string? line;
       
        StreamReader sr = new StreamReader(arrayOfChapter1[12]);
        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        meeting_with_P.AddAchievement();
        all_push.AchievementListGame.Add(meet_with_p);
        Console.ReadLine();
        Console.Clear();


    }
    public void Choose_of_answer()
    {
        music.Chapter_1_Unpleasant_meeting_music();
        string? lines;
        StreamReader srs = new StreamReader(arrayOfChapter1[13]);

        lines = srs.ReadLine();

        while (lines != null)
        {
            Console.WriteLine(lines);
            lines = srs.ReadLine();
        }
        srs.Close();
        string[] menuItems = new string[] { "1 - Мягко ответить Рею.\t\t", "2 - Грубо ответить Рею." };
        int active_menu = 0;
        while (true)
        {
            int x = 15; int y = 10;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < menuItems.Length; i++)
            {

                if (i == active_menu)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                    Console.ForegroundColor = ConsoleColor.White;

                Console.Write(menuItems[i]);

            }



            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.RightArrow:
                    if (active_menu < menuItems.Length - 1)
                    {
                        active_menu++;
                    }
                    continue;
                case ConsoleKey.LeftArrow:
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
                            Console.ResetColor();
                            music.Chapter_1_Unpleasant_meeting_music();
                            honor.AddHonor();
                            string? line;
                            StreamReader sr = new StreamReader(arrayOfChapter1[15]);

                            line = sr.ReadLine();

                            while (line != null)
                            {
                                Console.WriteLine(line);
                                line = sr.ReadLine();
                            }
                            sr.Close();
                            Console.ResetColor();
                            break;
                        case 1:
                            Console.ResetColor();
                            honor.RemoveHonor();
                            Console.Clear();

                            string? linee;
                            StreamReader sre = new StreamReader(arrayOfChapter1[14]);

                            linee = sre.ReadLine();

                            while (linee != null)
                            {
                                Console.WriteLine(linee);
                                linee = sre.ReadLine();
                            }
                            sre.Close();
                            Console.ResetColor();
                            break;

                    }
                    break;



            }
            break;
        }


        string? linew;
        StreamReader srw = new StreamReader(arrayOfChapter1[16]);

        linew = srw.ReadLine();

        while (linew != null)
        {
            Console.WriteLine(linew);
            linew = srw.ReadLine();
        }
        srw.Close();
        Console.WriteLine($"Простите, но мне нужно вас покинуть.Было приятно с Вами познакомиться, {getName.PlayerName}. ");
        Console.WriteLine("\n- Это взаимно, до встречи.");
  
        Console.ReadLine();
        Console.Clear();
    }
    public void Choose_of_Сonclusions()
    {
      
        music.Chapter_1_Unpleasant_meeting_music();
        Console.WriteLine($"{getName.PlayerName}, Вы видели тело и изучили его пока нам не помешали, не хотите поделиться выводами? - спросил Эмиль");

        string[] menuItems = new string[] { "1 - Эти убийства — это урок для людей.","\t 2 - Его убили за долги.","\t 3 - Я бы не хотел делиться выводами."};
        
        int active_menu = 0;
        while (true)
        {
            int x = 5; int y = 5;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < menuItems.Length; i++)
            {

                if (i == active_menu)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                    Console.ForegroundColor = ConsoleColor.White;

                Console.Write(menuItems[i]);

            }



            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.RightArrow:
                    if (active_menu < menuItems.Length - 1)
                    {
                        active_menu++;
                    }
                    continue;
                case ConsoleKey.LeftArrow:
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
                            Console.ResetColor();
                 
                            honor.AddHonor();
                            string? line;
                            StreamReader sr = new StreamReader(arrayOfChapter1[17]);

                            line = sr.ReadLine();

                            while (line != null)
                            {
                                Console.WriteLine(line);
                                line = sr.ReadLine();
                            }
                            sr.Close();

                            Console.ResetColor();
                            break;
                        case 1:
                          
                            Console.Clear();
                            Console.ResetColor();
                            honor.RemoveHonor();
                            string? lines;
                            StreamReader srs = new StreamReader(arrayOfChapter1[18]);

                            lines = srs.ReadLine();

                            while (lines != null)
                            {
                                Console.WriteLine(lines);
                                lines = srs.ReadLine();
                            }
                            srs.Close();
                            Console.ResetColor();
                            break;


                        case 2:
                            Console.ResetColor();
                            Console.Clear();
                            Console.ResetColor();
                            string? linew;
                            StreamReader srw = new StreamReader(arrayOfChapter1[19]);

                            linew = srw.ReadLine();

                            while (linew != null)
                            {
                                Console.WriteLine(linew);
                                linew = srw.ReadLine();
                            }
                            srw.Close();

                            break;

                    }
                    break;



            }
            break;
        }



    
    }
    public void Last_dialogue_with_Forsman()
    {

        string? line;

        StreamReader sr = new StreamReader(arrayOfChapter1[20]);
        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.ReadLine();
        Console.Clear();



    }
    public void Choose_of_detail()
    {

        Console.WriteLine($"-Эх... скажем так, досточтимый коронер сдал меня секретной службе.{getName.PlayerName}, я не сильно хочу об этом говорить.");
        music.Chapter_1_detail_history();

      
        string[] menuItems = new string[] { "1 - А я бы послушал эту историю.\t", "\t2 - Хорошо, закроем эту тему." };
        int active_menu = 0;



        while (true)
        {
            int x = 6; int y = 7;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < menuItems.Length; i++)
            {

                if (i == active_menu)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                    Console.ForegroundColor = ConsoleColor.White;

                Console.Write(menuItems[i]);

            }


            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.RightArrow:
                    if (active_menu < menuItems.Length - 1)
                    {
                        active_menu++;
                    }
                    continue;
                case ConsoleKey.LeftArrow:
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
                            string? line;
                            Console.Clear();
                            StreamReader sr = new StreamReader(arrayOfChapter1[21]);

                            line = sr.ReadLine();

                            while (line != null)
                            {
                                Console.WriteLine(line);
                                line = sr.ReadLine();
                            }
                            sr.Close();
                            Console.ResetColor();
                            Console.WriteLine("\n- Спасибо что помогли изучить труп, я отправляюсь к Бризгону.");
                            Console.ResetColor();

                            break;
                        case 1:
                            Console.Clear();
                            Console.ResetColor();
                            Console.WriteLine("- Хорошо, закроем эту тему. Спасибо что помогли изучить труп, я отправляюсь к Бризгону.");
                            Console.ResetColor();
                            break;

                    }
                    break;



            }
            break;
        }
 
       
        End_Chapter_1.AddAchievement();
        all_push.AchievementListGame.Add(end_chapter_1);
        Console.ReadLine();
        Console.Clear();

    }

}

public class Chapter_2 : Chapter_1
{
    
    public Achievement Scavenger = new Achievement("Падальщик");
    public Achievement scavenger = new Achievement("Падальщик", "Познакомьтесь с Бризгоном");
    
    public Achievement Punishers_notes = new Achievement("Записки Карателя");
    public Achievement punishers_notes = new Achievement("Записки Карателя", "Пройдите 2 главу");


    public string[] arrayOfChapter2 = new string[]
   {
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\3_Chapter_2_on_the_street.txt.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\3_Chapter_2_found_note.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\3_Chapter_2_found_note_aggresive_answer.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\3_Chapter_2_found_note_normal_answer.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\3_Chapter_2__secret_note.txt",
    };


    
     

    public void On_the_street()
    {

        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter2[0]);
        music.Sound_Chapter_2();
        music.Chapter_2_Near_the_dead();
        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Scavenger.AddAchievement();
        all_push.AchievementListGame.Add(scavenger);
        Console.ReadLine();
        Console.Clear();



    }

    public void Found_note()
    {
      

     
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter2[1]);
        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        

        string[] menuItems = new string[] { "1 - Надавить на Бризгона.\t", "\t2 - Шантажировать Бризгона." };
        int active_menu = 0;



        while (true)
        {
            int x = 6; int y = 7;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < menuItems.Length; i++)
            {

                if (i == active_menu)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                    Console.ForegroundColor = ConsoleColor.White;

                Console.Write(menuItems[i]);

            }


            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.RightArrow:
                    if (active_menu < menuItems.Length - 1)
                    {
                        active_menu++;
                    }
                    continue;
                case ConsoleKey.LeftArrow:
                    if (active_menu > 0)
                    {
                        active_menu--;
                    }
                    continue;
                case ConsoleKey.Enter:
                    switch (active_menu)
                    {
                        case 0:
                            Console.ResetColor();
                       
                            Console.Clear();
                            honor.RemoveHonor();
                            string? linew;
                            StreamReader srw = new StreamReader(arrayOfChapter2[2]);

                            linew = srw.ReadLine();

                            while (linew != null)
                            {
                                Console.WriteLine(linew);
                                linew = srw.ReadLine();
                            }
                            srw.Close();
                       

                            break;
                        case 1:
                            Console.ResetColor();
                            Console.Clear();
                            honor.AddHonor();
                            string? lines;
                            StreamReader srs = new StreamReader(arrayOfChapter2[3]);

                            lines = srs.ReadLine();

                            while (lines != null)
                            {
                                Console.WriteLine(lines);
                                lines = srs.ReadLine();
                            }
                            srs.Close();
                            Console.ResetColor();
                           
                            break;

                    }
                    break;



            }
            break;
        }
        
    }
  

    public void Secret_note()
    {
       
        music.Chapter_2_Near_the_dead();
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter2[4]);
  
        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();

      


    }

    public void Showdown_with_Brizgon() 
    {
       

        string[] menuItems = new string[] { "1 - Ударить Бризгона.\t", "\t2 - Уйти." };
        int active_menu = 0;

        

        while (true)
        {
            int x = 20; int y = 20;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < menuItems.Length; i++)
            {

                if (i == active_menu)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                    Console.ForegroundColor = ConsoleColor.White;

                Console.Write(menuItems[i]);

            }


            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.RightArrow:
                    if (active_menu < menuItems.Length - 1)
                    {
                        active_menu++;
                    }
                    continue;
                case ConsoleKey.LeftArrow:
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
                            Console.ResetColor();
                            Console.WriteLine("    Резким ударом руки Вы сбиваете Бризгона с ног, он падает среди трупов.\n");
                            Console.WriteLine("- Ай, за что?!\n");
                            Console.WriteLine("- За все!");

                            break;
                        case 1:
                            Console.Clear();
                            Console.ResetColor();
                            honor.AddHonor();
                            Console.WriteLine("- Нет у меня времени на тебя, пойди вон!");

                            break;

                    }
                    break;



            }
            break;
        }

   
        Console.WriteLine($"\n    Солдат из стражи увидел и окликнул Вас.\n\n- Детектив {getName.PlayerName}, коронер сказал срочно подойти к нему, новая жертва была найдена. Он попросил прийти как можно скорее.\n\n- Спасибо что передали, я сею минуту отправлюсь к нему.\r\n");
        Punishers_notes.AddAchievement();
        all_push.AchievementListGame.Add(punishers_notes);
        Console.ReadLine();
        Console.Clear();
    }

}


public class Chapter_3 : Chapter_2
{
    public Achievement Shadows_of_the_past = new Achievement("Тени прошлого");
    public Achievement shadows_of_the_past = new Achievement("Тени Прошлого", "Узнайте истории становления Эмиля, Роя и Балиана");


    public Achievement Heiress = new Achievement("Наследница");
    public Achievement heiress = new Achievement("Наследница", "Познакомтесь с Каей");


    public Achievement True_Friend = new Achievement("Верный друг");
    public Achievement true_friend = new Achievement("Верный друг", "Выберите имя для своей лошади");


  
    public Achievement Trap = new Achievement("Сломанная ловушка");
    public Achievement trap = new Achievement("Сломанная ловушка", "Обойдите ловушку Роя");

    public  Achievement Bad_day = new Achievement("Плохой день");
    public Achievement bad_day_end = new Achievement("Плохой день", "Пройдите игры на плохую концовку");

    public Achievement Professional = new Achievement("Профессионал");
    public Achievement good_day_end = new Achievement("Профессионал", "Пройдите игры на хорошую концовку");

    Fight fight_with_P = new Fight(150, 15, " ", 90, 5, "Преподобный","Преподобного");
    Fight fight_with_Balian = new Fight(150, 15, " ", 150, 10, "Балиан", "Балина");

    public string[] arrayOfChapter3 = new string[]
{
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_New_victim.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_Straight_talk.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_Question_from_Balian.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_QB_N_answer.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_QB_Y_answer.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_Baroness_in_danger.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_Near_the_estate.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_Meeting_with_Kaya.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_Investigation_with_Kaya.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_Murder_room.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_Invented_answer.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_Logical_answer.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_Farewell_to_Kaya.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_Back_to_the_tavern.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_Killer_found.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_Good_choice.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_Bad_choise.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_Choice_Reverend_save.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_Choice_Reverend_kill.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\4_Chapter_3_Talk_with_Zhest.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\!Bad_ending_part_1.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\!Bad_ending_part_2.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\!Bad_ending_Сoroners_note.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\!Bad_ending_part_3.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\!Good_ending_Road_to_port.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\!Good_ending_Motivation.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\!Good_ending_Y_motivation.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\!Good_ending_N_motivation.txt",
     "C:\\Users\\kagu_rhick\\source\\repos\\My_Game_C_Sharp\\My_Game_C_Sharp\\All_plot\\!Good_ending_part_1.txt",
};

 

    public void New_victim()
    {
        music.Sound_Chapter_3();
        music.Chapter_3_In_the_mortuary();
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter3[0]);
      
        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
       
        Console.ReadLine();
        Console.Clear();

    }

    public void Straight_talk()
    {
        
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter3[1]);

        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.WriteLine($"Ты должен меня понять{getName.PlayerName}.");
       

    }
    public void Support_selection()
    {
        
        string[] menuItems = new string[] { "1 - Поддержать Балиана.\t", "\t 2 - Спросить о записке." };
        int active_menu = 0;

        Shadows_of_the_past.AddAchievement();
        all_push.AchievementListGame.Add(shadows_of_the_past);

        while (true)
        {
            int x = 20; int y = 20;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < menuItems.Length; i++)
            {

                if (i == active_menu)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                    Console.ForegroundColor = ConsoleColor.White;

                Console.Write(menuItems[i]);

            }


            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.RightArrow:
                    if (active_menu < menuItems.Length - 1)
                    {
                        active_menu++;
                    }
                    continue;
                case ConsoleKey.LeftArrow:
                    if (active_menu > 0)
                    {
                        active_menu--;
                    }
                    continue;
                case ConsoleKey.Enter:
                    switch (active_menu)
                    {
                        case 0:
                            Console.ResetColor();
                            Console.Clear();
                            honor.AddHonor();

                            Console.WriteLine("- Иногда  нужно выбрать большее зло, чтобы сделать меньшее добро.\n");
                            Console.WriteLine("- Я рад что ты это понимаешь.\n");

                            string? line;
                            StreamReader sr = new StreamReader(arrayOfChapter3[2]);

                            line = sr.ReadLine();

                            while (line != null)
                            {
                                Console.WriteLine(line);
                                line = sr.ReadLine();
                            }
                            sr.Close();
                            Console.ResetColor();

                            break;
                        case 1:
                            Console.ResetColor();
                            Console.Clear();
                            string? lines;
                            StreamReader srs = new StreamReader(arrayOfChapter3[2]);

                            lines = srs.ReadLine();

                            while (lines != null)
                            {
                                Console.WriteLine(lines);
                                lines = srs.ReadLine();
                            }
                            srs.Close();
                            Console.ResetColor();

                            break; 
                    

                    }
                    break;



            }
            break;
        }

     
       




    }

    public void Question_from_Balian()
    {


   
        string[] menuItems = new string[] { "1 - Нет. Это вымысел культа.\t", "\t 2 - Да, но только сильные люди способны на такое." };
        int active_menu = 0;
 
        while (true)
        {
            int x = 20; int y = 20;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < menuItems.Length; i++)
            {

                if (i == active_menu)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                    Console.ForegroundColor = ConsoleColor.White;

                Console.Write(menuItems[i]);

            }


            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.RightArrow:
                    if (active_menu < menuItems.Length - 1)
                    {
                        active_menu++;
                    }
                    continue;
                case ConsoleKey.LeftArrow:
                    if (active_menu > 0)
                    {
                        active_menu--;
                    }
                    continue;
                case ConsoleKey.Enter:
                    switch (active_menu)
                    {
                        case 0:
                            Console.ResetColor();
                            Console.Clear();
                            honor.AddHonor();
                            string? line;
                            StreamReader sr = new StreamReader(arrayOfChapter3[3]);

                            line = sr.ReadLine();

                            while (line != null)
                            {
                                Console.WriteLine(line);
                                line = sr.ReadLine();
                            }
                            sr.Close();
                            
                            Console.ResetColor();
                        

                            break;
                        case 1:
                            Console.ResetColor();
                            Console.Clear();
                           
                            honor.AddHonor();
                            string? lines;
                            StreamReader srs = new StreamReader(arrayOfChapter3[4]);

                            lines = srs.ReadLine();

                            while (lines != null)
                            {
                                Console.WriteLine(lines);
                                lines = srs.ReadLine();
                            }
                            srs.Close();
                      
                            Console.ResetColor();

                            break;


                    }
                    break;



            }
            break;
        }

      


    }

    public void Baroness_in_danger()
    {
        music.Chapter_1_Main_square();
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter3[5]);

        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        Console.WriteLine($"- Поспеши {getName.PlayerName}, ее жизнь зависит от тебя");
        sr.Close();
        Console.ReadLine();
        Console.Clear();

    }

    public void Near_the_estate()
    {

        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter3[6]);

        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.ReadLine();
        Console.Clear();



    }

    public void Meeting_with_Kaya()
    {
        music.Chapter_3_Meeting_with_Kaya();
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter3[7]);

        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.WriteLine($"\n- Здравствуйте, меня зовут {getName.PlayerName}.Я детектив, который развязывает ряд странных убийств, у меня есть все основания\nпредполагать, что Ваша мама в опасности.");
    



    }

    public void Investigation_with_Kaya()
    {
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter3[8]);

        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
     
        Heiress.AddAchievement();
        all_push.AchievementListGame.Add(heiress);
        Console.ReadLine();
        Console.Clear();


    }

    public void Murder_room() 
    {
       
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter3[9]);

        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();



    }

    public void Сhoose_of_sedation()
    {
        music.Chapter_3_Meeting_with_Kaya();
       
        Console.WriteLine("\n- Новая жертва Аркон и он будет в корчме, почему убийца стал назначать место убийства, а не только имя?\n");
        Console.WriteLine($"- {getName.PlayerName},подождите, я хочу Вас спросить.\n");
        Console.WriteLine("- Я Вас слушаю.");
        Console.WriteLine("\n- Почему новой жертвой стала моя мать?\n");

     
       
        

        string[] menuItems = new string[] { "1 - Ибо убийца устал убивать ученых.\t", "\t 2 - Ибо Ваша мать оскорбила культ Красного Феникса." };
        int active_menu = 0;

        while (true)
        {
            int x = 10; int y = 18;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < menuItems.Length; i++)
            {

                if (i == active_menu)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                    Console.ForegroundColor = ConsoleColor.White;

                Console.Write(menuItems[i]);

            }


            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.RightArrow:
                    if (active_menu < menuItems.Length - 1)
                    {
                        active_menu++;
                    }
                    continue;
                case ConsoleKey.LeftArrow:
                    if (active_menu > 0)
                    {
                        active_menu--;
                    }
                    continue;
                case ConsoleKey.Enter:
                    switch (active_menu)
                    {
                        case 0:
                            Console.ResetColor();
                            Console.Clear();
                            honor.RemoveHonor();
                            string? line;
                            StreamReader sr = new StreamReader(arrayOfChapter3[10]);

                            line = sr.ReadLine();

                            while (line != null)
                            {
                                Console.WriteLine(line);
                                line = sr.ReadLine();
                            }
                            sr.Close();

                            Console.WriteLine();
                            Console.ResetColor();


                            break;
                        case 1:
                            Console.ResetColor();
                            Console.Clear();
                            honor.AddHonor();
                            string? lines;
                            StreamReader srs = new StreamReader(arrayOfChapter3[11]);

                            lines = srs.ReadLine();

                            while (lines != null)
                            {
                                Console.WriteLine(lines);
                                lines = srs.ReadLine();
                            }
                            srs.Close();
                            Console.WriteLine();
                            Console.ResetColor();

                            break;


                    }
                    break;



            }
            break;
        }





    }

    public void Farewell_to_Kaya() 
    {
        music.Chapter_3_Meeting_with_Kaya();
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter3[12]);

        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();

        Console.WriteLine("\n*Введите имя Вашей лошади в предложном падеже, оно останется с Вами до окончания игры:");
        getName.HorsName = Console.ReadLine();
       
        True_Friend.AddAchievement();
        all_push.AchievementListGame.Add(true_friend);
        Thread.Sleep(1000);
        Console.Clear();

        


    }

    public void Back_to_the_tavern() 
    {
        music.Chapter_3_Back_to_tavern();
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter3[13]);

        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.ReadLine();
        Console.Clear();


    }

    public void Killer_found() 
    {
        music.Chapter_3_Killer_found();
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter3[14]);

        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
     


    }
    public void Talk_with_Zhest()
    {
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter3[19]);

        line = sr.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.ReadLine();
        Console.Clear();
    }


    public void Main_check()
    {
     
       
        if (honor.Honor > 49)
        {
           

            string[] menuItems = new string[] { "1 - Избавь меня от своего вранья, готовся умереть.\t", "\t  2 - Я видел тела твоих жертв." };
            int active_menu = 0;

            while (true)
            {
                int x = 10; int y = 18;
                Console.SetCursorPosition(x, y);
                for (int i = 0; i < menuItems.Length; i++)
                {

                    if (i == active_menu)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else
                        Console.ForegroundColor = ConsoleColor.White;

                    Console.Write(menuItems[i]);

                }


                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.RightArrow:
                        if (active_menu < menuItems.Length - 1)
                        {
                            active_menu++;
                        }
                        continue;
                    case ConsoleKey.LeftArrow:
                        if (active_menu > 0)
                        {
                            active_menu--;
                        }
                        continue;
                    case ConsoleKey.Enter:
                        switch (active_menu)
                        {
                            case 0:
                                Console.ResetColor();
                                Console.Clear();
                                Bad_choose();
                                fight_with_P.HeroName = getName.PlayerName;
                                music.Chapter_3_Last_Fight();
                                fight_with_P.FightingWithEnemy();

                                Console.WriteLine("    Выйдя из корчмы Вы подозвали двух стражников и сообщили о нахождение трупа разыскиваемого убийцы на втором этаже\nи человека, который нуждается в помощи.Стражники сразу же отправились в корчму.");
                                //!!!!!!!!!!Музыка от концовки.
                                Talk_with_Zhest();
                                Bad_ending();
                                Console.ResetColor();


                                break;
                            case 1:
                                Console.ResetColor();
                                Console.Clear();
                                Good_choose();
                                Good_ending();
                                Console.ResetColor();

                                break;


                        }
                        break;



                }
                break;
            }
        

        }
        else
        {


            string[] menuItems = new string[] { "1 - Избавь меня от своего вранья, готовся умереть."};
            int active_menu = 0;
         
            while (true)
            {
                int x = 10; int y = 18;
                Console.SetCursorPosition(x, y);
                for (int i = 0; i < menuItems.Length; i++)
                {

                    if (i == active_menu)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else
                        Console.ForegroundColor = ConsoleColor.White;

                    Console.Write(menuItems[i]);

                }


                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.RightArrow:
                        if (active_menu < menuItems.Length - 1)
                        {
                            active_menu++;
                        }
                        continue;
                    case ConsoleKey.LeftArrow:
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
                                Console.ResetColor();
                                Bad_choose();
                                music.Chapter_3_Last_Fight();
                                fight_with_P.HeroName = getName.PlayerName;
                                fight_with_P.FightingWithEnemy();
                                //!!!!!!!!!!Музыка от концовки.
                                Console.WriteLine("    Выйдя из корчмы Вы подозвали двух стражников и сообщили о нахождение трупа разыскиваемого убийцы на втором этаже\nи человека, который нуждается в помощи.Стражники сразу же отправились в корчму.");
                                Console.ResetColor();
                             
                                break;
                            case 1:
                                Console.ResetColor();
                                Console.Clear();
                                Good_choose();
                                Good_ending();
                                Console.ResetColor();

                                break;


                        }
                        break;



                }
                break;
            }

       
            Talk_with_Zhest();
            Bad_ending();
        }

    }



    public void Good_choose()
    {

      
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter3[15]);

        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        Choose_Reverend();
        sr.Close();
       


    }
    public void Bad_choose()
    {

        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter3[16]);

        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
      
        sr.Close();



    }
    public void Choose_Reverend() 
    {
        string[] menuItems = new string[] { "1 - Я этого не позволю.\t\t\t\t", "2 - У меня нет на тебя времени." };
        int active_menu = 0;

        while (true)
        {
            int x = 14; int y = 18;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < menuItems.Length; i++)
            {

                if (i == active_menu)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                    Console.ForegroundColor = ConsoleColor.White;

                Console.Write(menuItems[i]);

            }


            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.RightArrow:
                    if (active_menu < menuItems.Length - 1)
                    {
                        active_menu++;
                    }
                    continue;
                case ConsoleKey.LeftArrow:
                    if (active_menu > 0)
                    {
                        active_menu--;
                    }
                    continue;
                case ConsoleKey.Enter:
                    switch (active_menu)
                    {
                        case 0:
                            Console.ResetColor();
                            Console.Clear();
                            string? line;
                            StreamReader sr = new StreamReader(arrayOfChapter3[18]);

                            line = sr.ReadLine();

                            while (line != null)
                            {
                                Console.WriteLine(line);
                                line = sr.ReadLine();
                            }
                            sr.Close();
                            music.Chapter_3_Last_Fight();
                            fight_with_P.FightingWithEnemy();
                            Console.ResetColor();


                            break;
                        case 1:
                            Console.ResetColor();
                            Console.Clear();
                            string? linew;
                            StreamReader srw = new StreamReader(arrayOfChapter3[17]);

                            linew = srw.ReadLine();

                            while (linew != null)
                            {
                                Console.WriteLine(linew);
                                linew = srw.ReadLine();
                            }
                            srw.Close();
                            Console.ResetColor();

                            break;


                    }
                    break;



            }
            break;
        }


        string? lines;
        StreamReader srs = new StreamReader(arrayOfChapter3[24]);

        lines = srs.ReadLine();

        while (lines != null)
        {
            Console.WriteLine(lines);
            lines = srs.ReadLine();
        }
        srs.Close();
       
        Trap.AddAchievement();
        all_push.AchievementListGame.Add(trap);
        Console.ReadLine();
        Console.Clear();


    }
    public void Bad_ending()
    {
        music.Chapter_3_Bad_ending();
        string? line;
        StreamReader sr = new StreamReader(arrayOfChapter3[20]);

        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }

        Console.WriteLine($"\n- {getName.PlayerName}, на секундочку.\n");

        string? lines;
        StreamReader srs = new StreamReader(arrayOfChapter3[21]);

        lines = srs.ReadLine();

        while (lines != null)
        {
            Console.WriteLine(lines);
            lines = srs.ReadLine();

        }

        string? linew;
        StreamReader srw = new StreamReader(arrayOfChapter3[22]);
        linew = srw.ReadLine();
        Console.Write("\n- "+getName.PlayerName);
        while (linew != null)
        {
            Console.WriteLine(linew);
            linew = srw.ReadLine();

        }
        Console.ReadLine();
        Console.Clear();
        string? lineq;
        StreamReader srq = new StreamReader(arrayOfChapter3[23]);
     
        lineq = srq.ReadLine();
        while (lineq != null)
        {
            Console.WriteLine(lineq);
            lineq = srq.ReadLine();

        }
  
        Console.WriteLine($"\n    Вскочив на {getName.HorsName},Вы отправились вдаль от города, города где Вы потерпели свою первую неудачу или все же\nудастся найти Балиана и решить старое дело?");
        Bad_day.AddAchievement();
        all_push.AchievementListGame.Add(bad_day_end);
        Console.ReadLine();
        Console.Clear();
        music.Sound_Chapter_End();

    }
    public void Good_ending()
    {
       
        string? lines;
        StreamReader srs = new StreamReader(arrayOfChapter3[25]);

        lines = srs.ReadLine();

        while (lines != null)
        {
            Console.WriteLine(lines);
            lines = srs.ReadLine();
        }
        srs.Close();
    
        string[] menuItems = new string[] { "1 - Это извращенная логика.\t\t\t\t", "2 - Да ты псих!" };
        int active_menu = 0;

        while (true)
        {
            int x = 12; int y = 10;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < menuItems.Length; i++)
            {

                if (i == active_menu)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                    Console.ForegroundColor = ConsoleColor.White;

                Console.Write(menuItems[i]);

            }


            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.RightArrow:
                    if (active_menu < menuItems.Length - 1)
                    {
                        active_menu++;
                    }
                    continue;
                case ConsoleKey.LeftArrow:
                    if (active_menu > 0)
                    {
                        active_menu--;
                    }
                    continue;
                case ConsoleKey.Enter:
                    switch (active_menu)
                    {
                        case 0:
                            Console.ResetColor();
                            Console.Clear();
                            string? line;
                            StreamReader sr = new StreamReader(arrayOfChapter3[26]);

                            line = sr.ReadLine();

                            while (line != null)
                            {
                                Console.WriteLine(line);
                                line = sr.ReadLine();
                            }
                            sr.Close();
                            Console.ResetColor();


                            break;
                        case 1:
                            Console.ResetColor();
                            Console.Clear();
                            string? lineq;
                            StreamReader srq = new StreamReader(arrayOfChapter3[27]);

                            lineq = srq.ReadLine();

                            while (lineq != null)
                            {
                                Console.WriteLine(lineq);
                                lineq = srq.ReadLine();
                            }
                            srq.Close();
                            Console.ResetColor();

                            break;


                    }
                    break;



            }
            break;
        }
        fight_with_P.HeroName = getName.PlayerName;
        music.Chapter_3_Last_Fight();
        fight_with_Balian.FightingWithEnemy();
        Console.WriteLine("    Выйдя из склада Вы подозвали двух стражников и сообщили о нахождение трупа разыскиваемого убийцы. Стражники сразу\nже отправились на склад.");

        Talk_with_Zhest();
        music.Chapter_3_Good_ending();
        string? linew;
        StreamReader srw = new StreamReader(arrayOfChapter3[20]);

        linew = srw.ReadLine();

        while (linew != null)
        {
            Console.WriteLine(linew);
            linew = srw.ReadLine();
        }

        Console.WriteLine($"\n- {getName.PlayerName}, на секундочку.\n");

        string? linee;
        StreamReader sre = new StreamReader(arrayOfChapter3[28]);

        linee = sre.ReadLine();

        while (linee != null)
        {
            Console.WriteLine(linee);
            linee = sre.ReadLine();
        }

        Console.WriteLine($"\n    Вскочив на {getName.HorsName}, Вы отправились в поиски новых дел и приключений. Так или иначе, это совсем другая история.");
        Professional.AddAchievement();
        all_push.AchievementListGame.Add(good_day_end);
        Console.ReadLine();
        Console.Clear();
        music.Sound_Chapter_End();
    }
}

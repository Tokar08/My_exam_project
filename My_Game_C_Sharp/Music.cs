using System.Media;


class Music
{
    public void Sound_Prologue()
    {
        Console.SetCursorPosition(51, 12);
        Console.WriteLine("Пролог");
        SoundPlayer player = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Пролог.wav");
        player.Play();
        Console.ReadLine();
        Console.Clear();
    }
    public void Sound_Chapter_1()
    {
        Console.SetCursorPosition(51, 12);
        Console.WriteLine("Глава 1");

        SoundPlayer players = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Глава первая.wav");
        players.Play();
        Console.ReadLine();
        Console.Clear();


    }
    public void Sound_Chapter_2()
    {
        Console.SetCursorPosition(51, 12);
        Console.WriteLine("Глава 2");

        SoundPlayer players = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Глава вторая.wav");
        players.Play();
        Console.ReadLine();
        Console.Clear();


    }
    public void Sound_Chapter_3() 
    {
        Console.SetCursorPosition(51, 12);
        Console.WriteLine("Глава 3");

        SoundPlayer players = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Глава третья.wav");
        players.Play();
        Console.ReadLine();
        Console.Clear();

    }


    public void Music_Sound()
    {

        SoundPlayer players = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Menu music.wav");
        players.Play();
      
    }
    public void Music_Menu()
    {

        SoundPlayer players = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\All_Menu_music.wav");
        players.Play();

    }
    public void Sound_Chapter_End() 
    {
        Console.SetCursorPosition(51, 12);
        Console.WriteLine("Конец");

        SoundPlayer players = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Конец.wav");
        players.Play();
        Console.ReadLine();
        Console.Clear();
    }
    public void Prologue_music()
    {


        SoundPlayer player = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Prologue_music.wav");
        player.Play();

    }
    public void Chapter_1_normal_music()
    {


        SoundPlayer player = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Chapter_1_normal_music.wav");
        player.Play();

    }
    public void Chapter_1_aggresive_music()
    {


        SoundPlayer player = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Chapter_1_aggresive_music.wav");
        player.Play();

    }
    public void Chapter_1_Main_square()
    {

        SoundPlayer player = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Chapter_1_main_square.wav");
        player.Play();

    }
    public void Chapter_1_severage()
    {

        SoundPlayer player = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Chapter_1_sewerage.wav");
        player.Play();

    }
    public void Chapter_1_Unpleasant_meeting_music()
    {

        SoundPlayer player = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Chapter_1_Unpleasant_meeting.wav");
        player.Play();

    }
    public void Chapter_1_detail_history()
    { 
        SoundPlayer player = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Chapter_1_detail_history.wav");
        player.Play();
     }
    public void Chapter_2_Near_the_dead()
    {
        SoundPlayer player = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Chapter_2_Near_the_dead.wav");
        player.Play();
    }
    public void Chapter_3_In_the_mortuary()
    {
        SoundPlayer player = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Chapter_3_In_the_mortuary.wav");
        player.Play();
    }

    public void Chapter_3_Baroness_in_dangery()
    {
        SoundPlayer player = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Chapter_3_Baroness_in_danger.wav");
        player.Play();
    }

    public void Chapter_3_Meeting_with_Kaya() 
    {
        SoundPlayer player = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Chapter_3_ Meeting_with_Kaya.wav");
        player.Play();


    }


    public void Chapter_3_Back_to_tavern()
    {
        SoundPlayer player = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Chapter_3_Back_to_tavern.wav");
        player.Play();


    }
    public void Chapter_3_Killer_found()
    {
        SoundPlayer player = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Chapter_3_Killer_found.wav");
        player.Play();


    }

    public void Chapter_3_Last_Fight() 
    {
        SoundPlayer player = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Chapter_3_Last_Fight.wav");
        player.Play();

    }

    public void Chapter_3_Bad_ending()
    {

        SoundPlayer player = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Chapter_3_Bad_ending.wav");
        player.Play();

    }
    public void Chapter_3_Good_ending()
    {

        SoundPlayer player = new SoundPlayer(@"C:\Users\kagu_rhick\source\repos\My_Game_C_Sharp\My_Game_C_Sharp\All_music\Chapter_3_Good_ending.wav");
        player.Play();

    }
}

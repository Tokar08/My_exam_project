
public class Game : Chapter_3
{
   
    public void AllChapters()
    {
        Part_1();
        Part_2();
        Part_3();

        //Chapter 1
        In_a_tavern_1();
        Choose_of_drinking();
        In_a_tavern_2();
        Choose_of_behavior();
        Main_square();
        Dialogue_with_Forsman_1();
        Dialogue_with_Forsman_2();
        Sewerage();
        Dead();
        Forsmans_jokes();
        Unpleasant_meeting_1();
        Unpleasant_meeting_2();
        Choose_of_answer();
        Choose_of_Сonclusions();
        Last_dialogue_with_Forsman();
        Choose_of_detail();

        ////Chapter 2
        On_the_street();
        Found_note();
        Secret_note();
        Showdown_with_Brizgon();

        //Chapter 3
        New_victim();
        Straight_talk();
        Support_selection();
        Question_from_Balian();
        Baroness_in_danger();
        Near_the_estate();
        Meeting_with_Kaya();
        Investigation_with_Kaya();
        Murder_room();
        Сhoose_of_sedation();
        Farewell_to_Kaya();
        Back_to_the_tavern();
        Killer_found();
        Main_check();


    }
    public void AllAchievement() 
    {
        Console.ForegroundColor= ConsoleColor.Cyan;
        all_push.IsEmpy(all_push.AchievementListGame);
        all_push.Show(all_push.AchievementListGame);


    }
}
public class Programm
{
  
    public static void Main()
    {
       
        Menu menu = new Menu();
        menu.mainMenu();

    }


}
using System;
using System.Text;

class Game
{
    public void AllChapters()
    {
        var game_chapter = new Chapter_3();

        //game_chapter.ChooseLvl();
        //game_chapter.Part_1();
        //game_chapter.Part_2();
        //game_chapter.Part_3();

        ////Chapter 1
        //game_chapter.In_a_tavern_1();
        //game_chapter.Choose_of_drinking();
        //game_chapter.In_a_tavern_2();

        //game_chapter.Choose_of_behavior();
        //game_chapter.Main_square();
        //game_chapter.Dialogue_with_Forsman_1();
        //game_chapter.Dialogue_with_Forsman_2();
        //game_chapter.Sewerage();
        //game_chapter.Dead();
        //game_chapter.Forsmans_jokes();
        //game_chapter.Unpleasant_meeting_1();
        //game_chapter.Unpleasant_meeting_2();
        //game_chapter.Choose_of_answer();
        //game_chapter.Choose_of_Сonclusions();
        //game_chapter.Last_dialogue_with_Forsman();
        //game_chapter.Choose_of_detail();

        //////Chapter 2
        game_chapter.On_the_street();
        game_chapter.Found_note();
        game_chapter.Secret_note();
        game_chapter.Showdown_with_Brizgon();

        ////Chapter 3
        //game_chapter.New_victim();
        //game_chapter.Straight_talk();
        //game_chapter.Support_selection();
        //game_chapter.Question_from_Balian();
        //game_chapter.Baroness_in_danger();
        //game_chapter.Near_the_estate();
        //game_chapter.Meeting_with_Kaya();
        //game_chapter.Investigation_with_Kaya();
        //game_chapter.Murder_room();
        //game_chapter.Сhoose_of_sedation();
        //game_chapter.Farewell_to_Kaya();
        //game_chapter.Back_to_the_tavern();
        //game_chapter.Killer_found();
        //game_chapter.Main_check();
        game_chapter.all_push.IsEmpy(game_chapter.all_push.AchievementListGame);
        game_chapter.all_push.Show(game_chapter.all_push.AchievementListGame);

    }

}
public class Programm
{
  
    public static void Main()
    {
        var game = new Game();

        game.AllChapters();

    }


}
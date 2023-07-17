using System;

namespace FootballMatchScoreBoard
{

    public class Program
    {
        public static void Main()
        {
            //var FootballMatchScore = new FootballMatchScore("Norfolk", "Suffolk");
            //FootballMatchScore.NotifyScore += (scorer, scoreteam1, scoreteam2) =>
            //{
            //Console.WriteLine($"{scorer} has scored a goal!!!! Curent Score  ====  {scoreteam1} : {scoreteam2}");
            //};
            //FootballMatchScore.IncreaseScoreTeam1();
            //FootballMatchScore.IncreaseScoreTeam2();

            var newMatch = new CustomEvent("Arsenal", "MANUnited§1");
            //subscribe
            newMatch.GoalScored += (scorer, team1Score, team2Score) =>
            {

                Console.WriteLine($"{scorer} scored. Current score is {team1Score}:{team2Score}.");
            };
            // Subscribing
            newMatch.GoalScored += PrintNewScoreDecorated;
            newMatch.IncreaseScoreTeam1New();

            // Unsubscribing
            newMatch.GoalScored -= PrintNewScoreDecorated;
            newMatch.IncreaseScoreTeam2New();

            static void PrintNewScoreDecorated(string scorer, int team1Score, int team2Score)
            {
                Console.WriteLine("***********************************************************");
                Console.WriteLine($"GOOOOAL!!! {scorer} scores!!! {team1Score}:{team2Score}!!!");
                Console.WriteLine("***********************************************************");
            }

        }
    }
}
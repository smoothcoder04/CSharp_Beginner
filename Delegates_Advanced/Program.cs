using System;

namespace Delegate_Advanced
{
    class Program
    {
        public static void Main()
        {
            FootballMatch LocalMatch = new FootballMatch("Norfolk", "Suffolk");
            LocalMatch.NotifyScore += (scorer, scoreTeam1, scoreTeam2) =>
            {
                Console.WriteLine($"{scorer} scored. Current status & score is {scoreTeam1} : {scoreTeam2}");
            };
            Console.WriteLine(LocalMatch.NotifyScore.GetInvocationList());
            LocalMatch.IncreaseScoreTeam1();
            LocalMatch.IncreaseScoreTeam2();
            LocalMatch.IncreaseScoreTeam1();
        }
    }
}
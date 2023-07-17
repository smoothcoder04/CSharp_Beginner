using System;

namespace EventDelegate
{
    class Program
    {
        public static void Main(string[] args)
        {
            var footballmatch = new FootballMatchScore("MithuFC", "RossFC");
            footballmatch.GoalScored += (sender, eventArgs) =>
            {
                Console.WriteLine($"{eventArgs.Scorer} scored");
                Console.WriteLine($"Score is {eventArgs.Team1Score}:{eventArgs.Team2Score}.");

            };

            footballmatch.IncreaseTeam1Score();
            footballmatch.IncreaseTeam2Score();
        }
    }
}
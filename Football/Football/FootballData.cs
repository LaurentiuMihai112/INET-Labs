using System;
using System.Collections.Generic;

namespace Football
{
    public class FootballData
    {
        public static void SmallestGoalDifference(List<FootballRow> footballRows)
        {
            int smallestDifference = Int32.MaxValue;
            string teamName = null;
            foreach (var row in footballRows)
            {
                if (row.GoalDifference() < smallestDifference)
                {
                    smallestDifference = row.GoalDifference();
                    teamName = row.Team;
                }
            }

            Console.WriteLine($"The team with the smallest goal difference is {teamName}");
        }
    }
}
using System;

namespace Football
{
    public class FootballRow
    {
        private string _team;
        private int _goalsFor;
        private int _goalsAgainst;

        public FootballRow(string team, int goalsFor, int goalsAgainst)
        {
            _team = team;
            _goalsFor = goalsFor;
            _goalsAgainst = goalsAgainst;
        }

        public string Team
        {
            get => _team;
            set => _team = value;
        }

        public int GoalsFor
        {
            get => _goalsFor;
            set => _goalsFor = value;
        }

        public int GoalsAgainst
        {
            get => _goalsAgainst;
            set => _goalsAgainst = value;
        }

        public int GoalDifference()
        {
            return Math.Abs(GoalsFor - GoalsAgainst);
        }
    }
}
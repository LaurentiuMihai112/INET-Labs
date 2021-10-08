namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            FootballFactory footballFactory = new FootballFactory();
            footballFactory.GetValues();
            FootballData.SmallestGoalDifference(footballFactory.FootballRows);
        }
    }
}
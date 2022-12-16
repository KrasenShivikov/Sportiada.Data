namespace Sportiada.Data.Models.Football
{
    public class FootballGoal
    {
        public int Id { get; set; }

        public int TypeId { get; set; }

        public FootballGoalType Type { get; set; }

        public int PlayerId { get; set; }

        public FootballPlayer Player { get; set; }

        public int Minute { get; set; }

        public bool FirstHalf { get; set; }

        public int GameStatisticId { get; set; }

        public FootballGameStatistic GameStatistic { get; set; }

        public int AssistanceId { get; set; }

        public FootballGoalAssistance Assistance { get; set; }
    }
}

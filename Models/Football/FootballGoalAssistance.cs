namespace Sportiada.Data.Models.Football
{
    public class FootballGoalAssistance
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }

        public FootballPlayer Player { get; set; }

        public int GoalId { get; set; }

        public FootballGoal Goal { get; set; }
    }
}

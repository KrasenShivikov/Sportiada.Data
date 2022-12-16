namespace Sportiada.Data.Models.Football
{
    using System.Collections.Generic;

    public class FootballGoalType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string picture { get; set; }

        public List<FootballGoal> Goals { get; set; } = new List<FootballGoal>();
    }
}

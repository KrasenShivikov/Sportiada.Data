using System.Collections.Generic;

namespace Sportiada.Data.Models.Football
{
    public class FootballGameStatisticType
    {
        public int id { get; set; }

        public string Name { get; set; }

        public List<FootballGameStatistic> GameStatistics { get; set; } = new List<FootballGameStatistic>();
    }
}

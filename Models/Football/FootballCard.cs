namespace Sportiada.Data.Models.Football
{
    public class FootballCard
    {
        public int Id { get; set; }

        public int TypeId { get; set; }

        public FootballCardType Type { get; set; }

        public int PlayerId { get; set; }

        public FootballPlayer Player { get; set; }

        public int Minute { get; set; }

        public bool FirstHalf { get; set; }

        public int GameStatisticId { get; set; }

        public FootballGameStatistic GameStatistic { get; set; }

    }
}

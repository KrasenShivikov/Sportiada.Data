namespace Sportiada.Data.Models.Football
{
    using System.Collections.Generic;

    public class FootballCompetition
    {
        public int Id { get; set; }

        public int SeasonId { get; set; }

        public Season Season { get; set; }

        public int TypeId { get; set; }

        public CompetitionType Type { get; set; }

        public int TournamentId { get; set; }

        public FootballTournament Tournament { get; set; }

        public List<FootballRound> Rounds { get; set; } = new List<FootballRound>();
    }
}

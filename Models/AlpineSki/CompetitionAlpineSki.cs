namespace Sportiada.Data.Models.AlpineSki
{
    using System;
    using System.Collections.Generic;

    public class CompetitionAlpineSki
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public int CompetitionTypeId { get; set; }

        public CompetitionType CompetitionType { get; set; }

        public string Track { get; set; }

        public int SeasonId { get; set; }

        public Season Season { get; set; }

        public int TournamentId { get; set; }

        public Tournament Tournament { get; set; }

        public int PlaceAlpineSkiId { get; set; }

        public PlaceAlpineSki PlaceAlpineSki { get; set; }

        public int DisciplineAlpineSkiId { get; set; }

        public AlpineSkiDisciplines Discipline { get; set; }

        public List<ResultAlpineSki> Results { get; set; } = new List<ResultAlpineSki>();

        public string FisTechnicalDelegate { get; set; }

        public string Referee { get; set; }

        public string AssistantRef { get; set; }

        public string CompetitionAlpineSkiChief { get; set; }

        public string StartRef { get; set; }

        public string FinishRef { get; set; }
    }
}

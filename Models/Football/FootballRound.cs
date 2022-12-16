namespace Sportiada.Data.Models.Football
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public class FootballRound
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public int CompetitionId { get; set; }

        public FootballCompetition Competition { get; set; }

        public List<FootballGame> Games { get; set; }
    }
}

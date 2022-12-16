using System;
using System.Collections.Generic;
using System.Text;

namespace Sportiada.Data.Models.Football
{
    public class FootballSquadPlayer
    {
        public int PlayerId { get; set; }

        public FootballPlayer Player { get; set; }

        public int SquadId { get; set; }

        public FootballSquad Squad { get; set; }

        public int Number { get; set; }

        public string Picture { get; set; }

        public string Position { get; set; }

        public string SquadType { get; set; }

        public string ContractStartDate { get; set; }

        public string ContractEndDate { get; set; }

        public bool OnLoan { get; set; }

        public bool JoinedInSummer { get; set; }

        public bool JoinedInWinter { get; set; }

        public bool LeftInSummer { get; set; }

        public bool LeftInWinter { get; set; }

    }
}

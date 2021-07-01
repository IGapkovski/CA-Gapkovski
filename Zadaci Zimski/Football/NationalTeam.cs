using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football
{
    class NationalTeam : FootballTeam
    {
        public string Country { get; set; }
        public int IntPlays { get; set; }
        public NationalTeam (string tName, string tSname, List<int> goals, double koef, string country, int plays)
        {
            TrenerName = tName; TrenerSurname = tSname; Goals = goals; Koef = koef; Country = country; IntPlays = plays;
        }

        public override double Achievement()
        {
            return Goals.Sum() * Koef + IntPlays;
        }
    }
}

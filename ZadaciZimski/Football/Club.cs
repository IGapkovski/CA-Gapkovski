using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Football
{
    class Club : FootballTeam
    {
        public string Name { get; set; }
        public int MedalCounts { get; set; }

        public Club (string tName, string tSname, List<int> goals, double koef, string name, int medals)
        {
            TrenerName = tName; TrenerSurname = tSname; Goals = goals; Koef = koef; Name = name; MedalCounts = medals;
        }

        public override double Achievement()
        {
            return Goals.Sum()*Koef + MedalCounts;
        }
    }
}

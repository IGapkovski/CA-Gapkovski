using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    abstract class FootballTeam
    {
        public string TrenerName { get; set; }
        public string TrenerSurname { get; set; }
        public List<int> Goals { get; set; }
        public int CountGoals { get { return Goals.Count; } }
        public double Koef { get; set; }
        public void ChangeKoef(double koef)
        {
            Koef = koef;
        }
        public abstract double Achievement();
        public FootballTeam()
        {

        }
    }
}

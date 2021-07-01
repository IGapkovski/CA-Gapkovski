using System;
using System.Collections.Generic;
using System.Text;

namespace NBA
{
    class NBAPlayer
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public double Points { get; set; }
        public double Assist { get; set; }
        public double Rebounds { get; set; }
        public NBAPlayer()
        {
            Name = "Unknown"; Team = "Unknown"; Points = 0.0; Assist = 0.0; Rebounds = 0.0;
        }
        public NBAPlayer(string name, string team, double points, double assist, double jumps)
        {
            Name = name; Team = team; Points = points; Assist = assist; Rebounds = jumps;
        }
        
        public virtual double Rating()
        {
            return Points * 45 / 100 + Assist * 30 / 100 + Rebounds * 25 / 100;
        }
        public virtual void Print()
        {
            Console.Write($"Points: {Points}, Asists: {Assist}, Rebounds: {Rebounds}, Rating: {Rating()}");
        }
    }
}

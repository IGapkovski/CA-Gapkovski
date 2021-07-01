using System;
using System.Collections.Generic;
using System.Text;

namespace NBA
{
    class AllStarPlayer : NBAPlayer
    {
        public double AllPoints { get; set; }
        public double AllAssist { get; set; }
        public double AllRebounds { get; set; }
        public AllStarPlayer(): base()
        {

        }
        public AllStarPlayer(NBAPlayer player, double points, double assists, double rebounds)
        {
            Name = player.Name; Points = player.Points; Team = player.Team; Assist = player.Assist; Rebounds = player.Rebounds; AllPoints = points; AllPoints = assists; AllRebounds = rebounds;
        }
        public AllStarPlayer(string name, string team, double points, double assist, double jumps, double allpoints, double allasists, double allrebounds): base(name, team, points, assist, jumps)
        {
            AllPoints = allpoints; AllAssist = allasists; AllRebounds = allrebounds;
        }

        public double AllStarRating()
        {
            return AllPoints * 30 / 100 + AllAssist * 40 / 100 + AllRebounds * 30 / 100;
        }
        
        public override double Rating()
        {
            return base.Rating() + AllStarRating();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"All Star Rating: {AllStarRating()}, New Rating: {Rating()}");
        }
    }
}

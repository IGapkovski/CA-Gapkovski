using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrika
{
    class Fabrika
    {
        public List<Rabotnik> Rabotnici { get; set; }
        public int BrojRabotnici { get; set; }
        public void PecatiVraboteni()
        {
            foreach(var rabotnik in Rabotnici)
            {
                rabotnik.Peacati();
            }
        }
        public void PecatiSoPlata(int plata)
        {
            foreach (var rabotnik in Rabotnici)
            {
                if(rabotnik.Plata >= plata)
                    rabotnik.Peacati();
            }
        }
    }
}

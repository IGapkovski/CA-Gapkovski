using System;

namespace Agol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi Agol vo forma Stepeni: Minuti: Sekundi:");
            Console.Write("Vnesi stepeni ");
            int stepeni = int.Parse(Console.ReadLine());
            Console.Write("Vnesi minuti ");
            int minuti = int.Parse(Console.ReadLine());
            Console.Write("Vnesi sekundi ");
            int sekundi = int.Parse(Console.ReadLine());
            var agol = new Agol(stepeni, minuti, sekundi);
            if(agol.IsValid())
                Console.WriteLine($"Agol vo sekundi: {agol.AgolVoSekundi()}");
            else
                Console.WriteLine("Nevalidni vrednosti za agol");
        }
        
    }
}

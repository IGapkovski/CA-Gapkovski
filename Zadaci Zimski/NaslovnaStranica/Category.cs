using System;
using System.Collections.Generic;
using System.Text;

namespace NaslovnaStranica
{
    class Category
    {
        public string Name { get; set; } = "unnamed";
        public void Print()
        {
            Console.WriteLine($"Category: {Name}");
        }
    }
    
}

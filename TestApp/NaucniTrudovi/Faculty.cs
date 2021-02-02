using System;
using System.Collections.Generic;
using System.Text;

namespace NaucniTrudovi
{
    class Faculty
    {
        public string Ime { get; set; }
        public List<Student> Studenti { get; set; }
        public Faculty (string ime, List<Student> studenti)
        {
            Ime = ime; Studenti = studenti;
        }

        public void Print()
        {
            int regular = 0; int phStudent = 0;
            foreach (var student in Studenti)
            {
                if (student is PhDStudent) phStudent++;
                else regular++;
                student.Print();
                Console.WriteLine($"PHD Student count = {phStudent} Regular students count = {regular}");
            }
        }
    }
}

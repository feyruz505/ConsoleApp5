using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    enum SchrolShep { verygood, middle, standart }

    internal class Student
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime? Age { get; set; }

        public double Avarge { get; set; }

        public SchrolShep schrolShep { get; set; }

    }
}

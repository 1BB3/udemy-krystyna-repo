using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_LINQ.SampleData
{
    enum Occupation
    {
        Engineer,
        Doctor,
        Teacher,
        Artist,
        Lawyer,
        Chef,
        Scientist,
        Athlete
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; } // in kilograms
        public double Height { get; set; } // in centimeters
        public Occupation Occupation { get; set; }
    }
}

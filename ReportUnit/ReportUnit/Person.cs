using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportUnit
{
    public class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private string HairColour { get; set; }
        private string EyeColour { get; set; }

        public Person(string name, int age, string eyeColour, string hairColour)
        {
            Name = name;
            Age = age;
            HairColour = hairColour;
            EyeColour = eyeColour;
        }
    }
}

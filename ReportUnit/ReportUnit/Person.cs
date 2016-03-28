namespace ReportUnit
{
    public class Person : Human
    {

        private string HairColour { get; set; }
        private string EyeColour { get; set; }

        public Person(string name, int age, string eyeColour, string hairColour)
        {
            // Using the properties from the Human Base Class
            Name = name;
            Age = age;     

            //Using properties from the Person Class.
            HairColour = hairColour;
            EyeColour = eyeColour;
        }

        public string GetHairColour()
        {
            return HairColour;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetAge()
        {
            return Age;
        }

        public string GetEyeColour()
        {
            return EyeColour;
        }

        public void ChangeHairColour(string newHairColour)
        {
            HairColour = newHairColour;
        }

        public void ChangeAge(int newAge)
        {
            Age = newAge;
        }

        public void ChangeName(string newName)
        {
            Name = newName;
        }
    }
}

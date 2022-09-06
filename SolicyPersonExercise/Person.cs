namespace SolicyPersonExercise
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, Profession profession)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Profession = profession;
        }

        public Person(Person person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            Age = person.Age;
            Profession = person.Profession;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Profession Profession { get; set; }

        public override string ToString()
        {
            return $"FirstName: {FirstName}\nLastName: {LastName}\nAge: {Age}\nProfesssion: {Profession}\n";
        }
    }
}

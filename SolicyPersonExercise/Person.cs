namespace SolicyPersonExercise
{
    public class Person
    {
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

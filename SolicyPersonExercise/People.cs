namespace SolicyPersonExercise
{
    public class People
    {
        private readonly IEnumerable<Person> _people;

        public People(IEnumerable<Person> people)
        {
            _people = people;
        }

        public IEnumerable<Person> GetPeopleByName(string name)
        {
            var peopleWithName = _people.Where(x => x.FirstName == name);
            return peopleWithName;
        }

        public IEnumerable<Person> GetPeopleByAgeLess(int age)
        {
            var peopleWithName = _people.Where(x => x.Age <= age);
            return peopleWithName;
        }

        public IEnumerable<Person> GetPeopleByProfession(Profession profession)
        {
            var peopleWithName = _people.Where(x => x.Profession == profession);
            return peopleWithName;
        }

        public IEnumerable<Person> GetPeopleByFilteringFunc(Func<Person, bool> func)
        {
            var peopleWithName = _people.Where(func);
            return peopleWithName;
        }

    }
}

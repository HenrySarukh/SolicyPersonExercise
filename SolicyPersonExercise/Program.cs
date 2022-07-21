using SolicyPersonExercise;

//Tests
var peopleExc = new List<Person>
{
     new Person
     (
        "Rustam",
        "Prodigy",
        30,
        Profession.Developer
    ),
    new Person
     (
        "Vazgen",
        "Prodigy",
        26,
        Profession.HR
    ),
    new Person
     (
        "Vazgen",
        "Prodigy",
        24,
        Profession.Marketing
    ),
   new Person
     (
        "Vazgen",
        "Prodigy",
        18,
        Profession.Developer
    ),
};

var people = new People(peopleExc);

var peopleWithName = people.GetPeopleByName("Vazgen");
Console.WriteLine("People with name Vazgen\n");

foreach (var person in peopleWithName)
{
    Console.WriteLine(person);
}

var peopleWithAge = people.GetPeopleByAgeLess(25);

Console.WriteLine("People with age less than 25\n");

foreach (var person in peopleWithAge)
{
    Console.WriteLine(person);
}

var peopleWithProfession = people.GetPeopleByProfession(Profession.Developer);
Console.WriteLine("People with profession Developer\n");

foreach (var person in peopleWithProfession)
{
    Console.WriteLine(person);
}

Console.WriteLine("People with age more than 25 (Custom filter)\n");
var peopleFiltered = people.GetPeopleByFilteringFunc((Person p) => p.Age > 25);

foreach (var person in peopleFiltered)
{
    Console.WriteLine(person);
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // ARRAY
        string[] courts = { "Johannesburg", "Pretoria", "Soweto" };

        Console.WriteLine(courts[0]);

        // LIST
        List<string> cases = new List<string>();

        cases.Add("State vs John");
        cases.Add("State vs James");
        cases.Add("State vs Peter");

        Console.WriteLine(cases[1]);

        // DICTIONARY
        Dictionary<int, string> caseNumbers = new Dictionary<int, string>();

        caseNumbers.Add(1, "JHB001");
        caseNumbers.Add(2, "JHB002");
        caseNumbers.Add(3, "JHB003");

        Console.WriteLine(caseNumbers[2]);

        // DICTIONARY WITH OBJECTS

        Dictionary<int, Person> people = new Dictionary<int, Person>();

        people.Add(1, new Person
        {
            Name = "John",
            Age = 25
        });

        people.Add(2, new Person
        {
            Name = "James",
            Age = 30
        });

        Console.WriteLine(people[1].Name);
        Console.WriteLine(people[1].Age);

        // this is confusing sometimes
        int month = (int)Months.April;
        Console.WriteLine(month);
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

enum Months { 
    January,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December

}
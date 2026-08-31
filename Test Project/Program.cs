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
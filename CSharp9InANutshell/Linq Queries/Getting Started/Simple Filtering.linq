<Query Kind="Statements" />

string[] names = { "Tom", "Dick", "Harry" };

IEnumerable<string> filteredNames = Enumerable.Where(names, n => n.Length >= 4);

foreach (string n in filteredNames)
{
	
}
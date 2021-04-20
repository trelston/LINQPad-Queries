<Query Kind="Statements" />

//Init-only accessors are allowed to mutate readonly fields:

var person = new Person { FirstName = "Joe", LastName = "Bloggs" }.Dump();

class Person
{
	readonly string _firstName;
	readonly string _lastName;
	
	public string LastName
	{
		get { return _lastName; }
		init { _lastName = value ?? throw new ArgumentException(nameof (LastName)); }
	}
	
	
	public string FirstName
	{
		get { return _firstName; }
		init { _firstName = value ?? throw new ArgumentException(nameof (FirstName)); }
	}
	
}
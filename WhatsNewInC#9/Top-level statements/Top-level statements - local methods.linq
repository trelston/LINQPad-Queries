<Query Kind="Statements" />

string greeting = "Hello, world";


//Top-level statements can be followed by methods.
//These methods can access variables declared by the top-level statements, making them "local methods"
//(so they cannot be overloaded)

void HelloWorld() => greeting.Dump();

//Top level statements in C# 9 can also be followed by type and namespace declarations:

class Foo
{
	public Foo()
	{
		
	}
}

namespace Test
{
	class Foo
	{
		
	}
}
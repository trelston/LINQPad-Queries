<Query Kind="Program" />

// All delegate instances have multicast capability

void Main()
{
	SomeDelegate d = SomeMethod1;
	d += SomeMethod2;
	
	d();
	" -- SomeMethod1 and SomeMethod2 both fired \n\n".Dump();
	
	d -= SomeMethod1;
	d();
	" -- Only SomeMethod2 fired".Dump();
		
}

// Define other methods and classes here
delegate void SomeDelegate();
void SomeMethod1 () => "SomeMethod1".Dump();
void SomeMethod2 () => "SomeMethod2".Dump();
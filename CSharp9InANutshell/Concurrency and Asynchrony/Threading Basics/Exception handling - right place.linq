<Query Kind="Program" />

//The remedy is to move the exception handler into the Go method
static void Main()
{
	new Thread (Go).Start();
}

static void Go()
{
	try
	{
		throw null;    // The NullReferenceException will get caught below
	}
	catch (Exception ex)
	{
		//Typically log the exception, and/or signal another thread
		// that we've come unstuck
		ex.Dump ("Caught!");
	}
}
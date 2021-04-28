<Query Kind="Program" />

//Sometimes, you’ll want to pass arguments to the thread’s startup method. 
//The easiest way to do this is with a lambda expression that calls the method with the desired arguments
static void Main()
{
	Thread t = new Thread ( () => Print ("Hello from t!") );
	t.Start();
}

static void Print (string message) { Console.WriteLine (message); }
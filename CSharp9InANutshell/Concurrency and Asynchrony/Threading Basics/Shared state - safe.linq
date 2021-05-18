<Query Kind="Program" />

void Main()
{
	ThreadSafe.Main();
}

class ThreadSafe 
{
	static bool _done;
	static readonly object _locker = new object();
	
	public static void Main()
	{
		new Thread (Go).Start();
		Go();
	}
	
	static void Go()
	{
		lock (_locker)
		{
			if (!_done) { Console.WriteLine ("Done"); _done = true; }
		}
	}
}

//When two threads simultaneously contend a lock (which can be upon any reference-type object; in this case, _locker), 
//one thread waits, or blocks, until the lock becomes available. 
//In this case, it ensures that only one thread can enter its code block at a time, and “Done” will be printed just once. 
//Code that’s protected in such a manner—from indeterminacy in a multithreaded context—is called thread safe.

//Locking is not a silver bullet for thread safety—it’s easy to forget to lock around accessing a field, and locking can create problems of its own (such as deadlocking).

//A good example of when you might use locking is around accessing a shared in-memory cache for frequently accessed 
//database objects in an ASP.NET application.This kind of application is simple to get right, and there’s no chance of deadlocking. 
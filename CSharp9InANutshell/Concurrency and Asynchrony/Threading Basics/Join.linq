<Query Kind="Statements" />

Thread t = new Thread (Go);
t.Start();
//You can wait for another thread to end by calling its Join method
t.Join();
Console.WriteLine ("Thread t has ended!");

void Go()
{
	for (int i = 0; i < 1000; i++) Console.Write ("y");
}

//This prints “y” 1,000 times, followed by “Thread t has ended!” immediately afterward. 
//You can include a timeout when calling Join, either in milliseconds or as a TimeSpan. 
//It then returns true if the thread ended or false if it timed out.
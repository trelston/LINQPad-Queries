<Query Kind="Statements" />

//You can create and start a new thread by instantiating a Thread object and calling its Start method. 
//The simplest constructor for Thread takes a ThreadStart delegate: a parameterless method indicating where execution should begin

Thread t = new Thread(WriteY);          // Kick off a new thread
t.Start();                               // running WriteY()

// Simultaneously, do something on the main thread.
for (int i = 0; i < 1000; i++) Console.WriteLine("x");

void WriteY()
{
	//The static Thread.CurrentThread property gives you the currently executing thread:
	Console.WriteLine(Thread.CurrentThread.Name);

	for (int i = 0; i < 1000; i++) Console.WriteLine("y");
}

//A thread is said to be preempted at the points at which its execution is interspersed with the execution of code on another thread. 
//The term often crops up in explaining why something has gone wrong!

//After it’s started, a thread’s IsAlive property returns true, until the point at which the thread ends.

//Each thread has a Name property that you can set for the benefit of debugging

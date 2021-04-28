<Query Kind="Program" />

//By default, threads you create explicitly are foreground threads. Foreground threads keep the application alive 
//for as long as any one of them is running, whereas background threads do not. 
//After all foreground threads finish, the application ends, and any background threads still running abruptly terminate

//A thread’s foreground/background status has no relation to its priority (allocation of execution time).

//You can query or change a thread’s background status using its IsBackground property:
static void Main(string[] args)
{
	Thread worker = new Thread(() => Console.ReadLine());
	if (args.Length > 0) worker.IsBackground = true;
	worker.Start();
}

//If this program is called with no arguments, 
//the worker thread assumes foreground status and will wait on the ReadLine statement for the user to press Enter. 
//Meanwhile, the main thread exits, but the application keeps running because a foreground thread is still alive. 
//On the other hand, if an argument is passed to Main(), the worker is assigned background status, and the program exits 
//almost immediately as the main thread ends (terminating the ReadLine).

//When a process terminates in this manner, any finally blocks in the execution stack of background threads are circumvented. 
//If your program employs finally (or using) blocks to perform cleanup work such as deleting temporary files, 
//you can avoid this by explicitly waiting out such background threads upon exiting an application, 
//either by joining the thread or with a signaling construct

//In either case, you should specify a timeout, so you can abandon a renegade thread should it refuse to finish; 
//otherwise your application will fail to close without the user having to enlist help from the Task Manager 
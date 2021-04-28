<Query Kind="Statements" />

//Thread.Sleep pauses the current thread for a specified period:

Thread.Sleep(TimeSpan.FromHours(1));  // Sleep for 1 hourThread.Sleep (500);                     
Thread.Sleep(500);  // Sleep for 500 milliseconds

//Thread.Sleep(0) relinquishes the thread’s current time slice immediately, voluntarily handing over the CPU to other threads. 
//Thread.Yield() does the same thing except that it relinquishes only to threads running on the same processor.

//Sleep(0) or Yield is occasionally useful in production code for advanced performance tweaks. 
//It’s also an excellent diagnostic tool for helping to uncover thread safety issues: 
//if inserting Thread.Yield() anywhere in your code breaks the program, you almost certainly have a bug.

//While waiting on a Sleep or Join, a thread is blocked.
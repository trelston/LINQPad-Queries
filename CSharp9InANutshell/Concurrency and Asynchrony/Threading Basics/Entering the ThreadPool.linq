<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//Whenever you start a thread, a few hundred microseconds are spent organizing such things as a fresh local variable stack. 
//The thread pool cuts this overhead by having a pool of pre-created recyclable threads. 
//Thread pooling is essential for efficient parallel programming and fine-grained concurrency; 
//it allows short operations to run without being overwhelmed with the overhead of thread startup.

//There are a few things to be wary of when using pooled threads:
// - You cannot set the Name of a pooled thread, making debugging more difficult
//   (although you can attach a description when debugging in Visual Studio’s Threads window).
// - Pooled threads are always background threads.
// - Blocking pooled threads can degrade performance

//You can determine whether you’re currently executing on a pooled thread via the property Thread.CurrentThread.IsThreadPoolThread.

//The easiest way to explicitly run something on a pooled thread is to use Task.Run
// Task is in System.Threading.Tasks
Task.Run (() => Console.WriteLine ("Hello from the thread pool"));

//Because tasks didn’t exist prior to .NET Framework 4.0, a common alternative is to call ThreadPool.QueueUserWorkItem
// The old-school way:
ThreadPool.QueueUserWorkItem (notUsed => Console.WriteLine ("Hello, old-school"));

//The following use the thread pool implicitly:
// - ASP.NET Core and Web API application servers
// - System.Timers.Timer and System.Threading.Timer
// - The parallel programming constructs
// - The (legacy) BackgroundWorker class

//The thread pool serves another function, which is to ensure that a temporary excess of compute-bound work does not cause CPU 
//oversubscription. Oversubscription is the condition of there being more active threads than CPU cores, with the OS 
//having to time-slice threads. Oversubscription hurts performance because time-slicing requires expensive context switches 
//and can invalidate the CPU caches that have become essential in delivering performance to modern processors.

//The CLR prevents oversubscription in the thread pool by queuing tasks and throttling their startup. 
//It begins by running as many concurrent tasks as there are hardware cores, and then tunes the level of concurrency 
//via a hill-climbing algorithm, continually adjusting the workload in a particular direction. 
//If throughput improves, it continues in the same direction (otherwise it reverses). 
//This ensures that it always tracks the optimal performance curve—even in the face of competing process activity on the computer.

//The CLR’s strategy works best if two conditions are met:
// - Work items are mostly short -running(< 250 ms, or ideally < 100 ms), so that the CLR has plenty of opportunities to
//   measure and adjust.
// - Jobs that spend most of their time blocked do not dominate the pool


//Blocking is troublesome because it gives the CLR the false idea that it’s loading up the CPU. 
//The CLR is smart enough to detect and compensate (by injecting more threads into the pool), 
//although this can make the pool vulnerable to subsequent oversubscription. 
//It also can introduce latency because the CLR throttles the rate at which it injects new threads, 
//particularly early in an application’s life (more so on client operating systems where it favors lower resource consumption).

//Maintaining good hygiene in the thread pool is particularly relevant when you want to fully utilize the CPU 










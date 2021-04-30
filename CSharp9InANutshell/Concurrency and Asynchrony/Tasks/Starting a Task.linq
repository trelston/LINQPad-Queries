<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

// A Task is higher-level abstraction—it represents a concurrent operation that might or might not be backed by a thread.
//Tasks are compositional (you can chain them together through the use of continuations).
//They can use the thread pool to lessen startup latency, and with a TaskCompletionSource, 
//they can employ a callback approach that avoids threads altogether while waiting on I/O-bound operations.

//The easiest way to start a Task backed by a thread is with the 
//static method Task.Run (the Task class is in the System.Threading.Tasks namespace). 
//Simply pass in an Action delegate:

Task.Run (() => Console.WriteLine ("Foo"));

//Tasks use pooled threads by default, which are background threads. 
//This means that when the main thread ends, so do any tasks that you create. 
//Hence, to run these examples from a Console application, you must block the main thread after 
//starting the task (for instance, by Waiting the task or by calling Console.ReadLine):
Task.Run(() => Console.WriteLine("Foo"));
Console.ReadLine();

//Task.Run returns a Task object that we can use to monitor its progress, rather like a Thread object. 
//(Notice, however, that we didn’t call Start after calling Task.Run because this method creates “hot” tasks; 
//you can instead use Task’s constructor to create “cold” tasks, although this is rarely done in practice.)

//You can track a task’s execution status via its Status property.
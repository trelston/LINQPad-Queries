<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//Unlike with threads, tasks conveniently propagate exceptions. 
//So, if the code in your task throws an unhandled exception (in other words, if your task faults), 
//that exception is automatically rethrown to whoever calls Wait()—or accesses the Result property of a Task<TResult>

// Start a Task that throws a NullReferenceException:
Task task = Task.Run (() => { throw null; });
try 
{
	task.Wait();
}
catch (AggregateException aex)
{
	if (aex.InnerException is NullReferenceException)
		Console.WriteLine ("Null!");
	else
		throw;
}

//The CLR wraps the exception in an AggregateException in order to play well with parallel programming scenarios
//You can test for a faulted task without rethrowing the exception via the IsFaulted and IsCanceled properties of the Task. 

//With autonomous “set-and-forget” tasks (those for which you don’t rendezvous via Wait() or Result, or a continuation that does the same), 
//it’s good practice to explicitly exception-handle the task code to avoid silent failure, just as you would with a thread.

//Ignoring exceptions is fine when an exception solely indicates a failure to obtain a result that you’re no longer interested in. 
//For example, if a user cancels a request to download a web page, we wouldn’t care if it turns out that the web page didn’t exist.

//Ignoring exceptions is problematic when an exception indicates a bug in your program, for two reasons:
// - The bug may have left your program in an invalid state.
// - More exceptions may occur later as a result of the bug, and failure to log the initial error can make diagnosis difficult.

//You can subscribe to unobserved exceptions at a global level via the static event TaskScheduler.UnobservedTaskException; 
//handling this event and logging the error can make good sense.

//There are a couple of interesting nuances on what counts as unobserved:
// - Tasks waited upon with a timeout will generate an unobserved exception if the fault occurs after the timeout interval.
// - The act of checking a task’s Exception property after it has faulted makes the exception “observed.”

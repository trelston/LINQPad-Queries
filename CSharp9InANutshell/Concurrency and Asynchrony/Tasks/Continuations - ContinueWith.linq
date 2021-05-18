<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

// (See Chapter 23 for more on using ContinueWith.)

//The other way to attach a continuation is by calling the task’s ContinueWith method:
Task<int> primeNumberTask = Task.Run (() =>
	Enumerable.Range (2, 3000000).Count (n => Enumerable.Range (2, (int)Math.Sqrt(n)-1).All (i => n % i > 0)));

primeNumberTask.ContinueWith (antecedent => 
{
	int result = antecedent.Result;
	Console.WriteLine (result);          // Writes 123
});

//ContinueWith itself returns a Task, which is useful if you want to attach further continuations. 
//However, you must deal directly with AggregateException if the task faults, and write extra code to marshal the continuation in 
//UI applications.

//And in non-UI contexts, you must specify TaskContinuationOptions.ExecuteSynchronously if you want the continuation to execute on the same thread; 
//otherwise it will bounce to the thread pool. ContinueWith is particularly useful in parallel programming scenarios
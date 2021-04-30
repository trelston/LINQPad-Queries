<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//A continuation says to a task, “when you’ve finished, continue by doing something else.”

//A continuation is usually implemented by a callback that executes once upon completion of an operation. 
//There are two ways to attach a continuation to a task. 
//The first is particularly significant because it’s used by C#’s asynchronous functions, as you’ll see soon.
Task<int> primeNumberTask = Task.Run (() =>
	Enumerable.Range (2, 3000000).Count (n => Enumerable.Range (2, (int)Math.Sqrt(n)-1).All (i => n % i > 0)));

var awaiter = primeNumberTask.GetAwaiter();
awaiter.OnCompleted (() => 
{
	int result = awaiter.GetResult();
	Console.WriteLine (result);       // Writes result
});

//Calling GetAwaiter on the task returns an awaiter object whose OnCompleted method tells the antecedent task (primeNumberTask) 
//to execute a delegate when it finishes (or faults). 
//It’s valid to attach a continuation to an already-completed task, in which case the continuation will be scheduled to execute right away.
//An awaiter is any object that exposes the two methods that we’ve just seen (OnCompleted and GetResult) and a Boolean property called IsCompleted. 


//If an antecedent task faults, the exception is rethrown when the continuation code calls awaiter.GetResult(). 
//Rather than calling GetResult, we could simply access the Result property of the antecedent. 
//The benefit of calling GetResult is that if the antecedent faults, the exception is thrown directly without being wrapped 
//in AggregateException, allowing for simpler and cleaner catch blocks.

//For nongeneric tasks, GetResult() has a void return value. Its useful function is then solely to rethrow exceptions.


//If a synchronization context is present, OnCompleted automatically captures it and posts the continuation to that context. 
//This is very useful in rich client applications because it bounces the continuation back to the UI thread.
//In writing libraries, however, it’s not usually desirable because the relatively expensive UI-thread-bounce should occur 
//just once upon leaving the library rather than between method calls.

var awaiter1 = primeNumberTask.ConfigureAwait (false).GetAwaiter();

//If no synchronization context is present—or you use ConfigureAwait(false)—the continuation will (in general) 
//execute on the same thread as the antecedent, avoiding unnecessary overhead.








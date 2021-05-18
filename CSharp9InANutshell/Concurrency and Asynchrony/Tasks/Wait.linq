<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//Calling Wait on a task blocks until it completes and is the equivalent of calling Join on a thread:
Task task = Task.Run (() =>
{
	Console.WriteLine ("Task started");
	Thread.Sleep (2000);
	Console.WriteLine ("Foo");
});
Console.WriteLine (task.IsCompleted);  // False
task.Wait();  // Blocks until task is complete

//Wait lets you optionally specify a timeout and a cancellation token to end the wait early
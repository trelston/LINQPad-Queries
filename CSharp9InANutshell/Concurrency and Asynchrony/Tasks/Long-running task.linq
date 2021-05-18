<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//By default, the CLR runs tasks on pooled threads, which is ideal for short-running compute-bound work. 
//For longer-running and blocking operations (such as our preceding example), you can prevent use of a pooled thread as follows:
Task task = Task.Factory.StartNew (() =>
{
	Console.WriteLine ("Task started");
	Thread.Sleep (2000);
	Console.WriteLine ("Foo");
}, TaskCreationOptions.LongRunning);

task.Wait();  // Blocks until task is complete
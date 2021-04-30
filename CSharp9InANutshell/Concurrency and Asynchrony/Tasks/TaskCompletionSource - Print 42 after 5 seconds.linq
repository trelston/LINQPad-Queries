<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

// TaskCompletionSource lets you create a task out of any operation that starts and finishes some time later
// It works by giving you a “slave” task that you manually drive—by indicating when the operation finishes or faults.
// This is ideal for I/O-bound work: you get all the benefits of tasks 
// (with their ability to propagate return values, exceptions, and continuations) 
// without blocking a thread for the duration of the operation.

//To use TaskCompletionSource, you simply instantiate the class. 
//It exposes a Task property that returns a task upon which you can wait and attach continuations—just as with any other task. 
//The task, however, is controlled entirely by the TaskCompletionSource object via the following methods:

//public class TaskCompletionSource<TResult>
//{
//	public void SetResult(TResult result);
//	public void SetException(Exception exception);
//	public void SetCanceled();
//
//	public bool TrySetResult(TResult result);
//	public bool TrySetException(Exception exception);
//	public bool TrySetCanceled();
//	public bool TrySetCanceled(CancellationToken cancellationToken);
//  ...
//}

//Calling any of these methods signals the task, putting it into a completed, faulted, or canceled state 
//You’re supposed to call one of these methods exactly once: 
//if called again, SetResult, SetException, or SetCanceled will throw an exception, whereas the Try* methods return false.

var tcs = new TaskCompletionSource<int>();

new Thread (() => { Thread.Sleep (5000); tcs.SetResult (42); }).Start();

Task<int> task = tcs.Task;         // Our "slave" task.
Console.WriteLine (task.Result);   // 42
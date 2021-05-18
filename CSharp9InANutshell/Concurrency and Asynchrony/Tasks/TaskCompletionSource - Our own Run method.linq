<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//With TaskCompletionSource, we can write our own Run method:

void Main()
{
	Task<int> task = Run (() => { Thread.Sleep (5000); return 42; });
	task.Result.Dump();
}

Task<TResult> Run<TResult> (Func<TResult> function)
{
	var tcs = new TaskCompletionSource<TResult>();
	new Thread (() => 
	{
		try { tcs.SetResult (function()); }
		catch (Exception ex) { tcs.SetException (ex); }
	}).Start();
	return tcs.Task;
}

//Calling this method is equivalent to calling Task.Factory.StartNew with the TaskCreationOptions.LongRunning option 
//to request a nonpooled thread.
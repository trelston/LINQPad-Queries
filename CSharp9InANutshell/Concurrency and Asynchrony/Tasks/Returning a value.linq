<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//Task has a generic subclass called Task<TResult>, which allows a task to emit a return value. 
//You can obtain a Task<TResult> by calling Task.Run with a Func<TResult> delegate (or a compatible lambda expression) instead of an Action:

Task<int> task = Task.Run (() => { Console.WriteLine ("Foo"); return 3; });

int result = task.Result;      // Blocks if not already finished
Console.WriteLine (result);    // 3

//You can obtain the result later by querying the Result property. 
//If the task hasn’t yet finished, accessing this property will block the current thread until the task finishes:
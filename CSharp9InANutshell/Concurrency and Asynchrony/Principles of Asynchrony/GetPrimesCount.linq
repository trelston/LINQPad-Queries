<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//Tasks are ideally suited to asynchronous programming, because they support continuations, which are essential for asynchrony 

//For compute-bound methods, we use Task.Run to initiate thread-bound concurrency. Simply by returning the task to the caller, we create an asynchronous method.

// What distinguishes asynchronous programming is that we aim to do so lower in the call graph, so that in rich-client applications, 
// higher-level methods can remain on the UI thread and access controls and shared state without thread-safety issues.


//To illustrate, consider the following method that computes and counts prime numbers, using all available cores 
void Main()
{
	DisplayPrimeCounts();
}

void DisplayPrimeCounts()
{
	for (int i = 0; i < 10; i++)
		Console.WriteLine (GetPrimesCount (i*1000000 + 2, 1000000) +
			" primes between " + (i*1000000) + " and " + ((i+1)*1000000-1));
	
	Console.WriteLine ("Done!");
}

int GetPrimesCount (int start, int count)
{
	return
		ParallelEnumerable.Range (start, count).Count (n => 
			Enumerable.Range (2, (int)Math.Sqrt(n)-1).All (i => n % i > 0));
}
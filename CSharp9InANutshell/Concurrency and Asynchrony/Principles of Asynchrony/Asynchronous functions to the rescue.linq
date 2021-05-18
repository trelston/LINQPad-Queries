<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>


// async and await are essential for implementing asynchrony without excessive complexity. 
void Main()
{
	DisplayPrimeCountsAsync();
}

async Task DisplayPrimeCountsAsync()
{
	for (int i = 0; i < 10; i++)
		Console.WriteLine (await GetPrimesCountAsync (i*1000000 + 2, 1000000) +
			" primes between " + (i*1000000) + " and " + ((i+1)*1000000-1));
	
	Console.WriteLine ("Done!");
}

Task<int> GetPrimesCountAsync (int start, int count)
{
	return Task.Run (() => 
		ParallelEnumerable.Range (start, count).Count (n => 
			Enumerable.Range (2, (int) Math.Sqrt(n)-1).All (i => n % i > 0)));
}

//Another way of looking at the problem is that imperative looping constructs (for, foreach, and so on), 
//do not mix well with continuations, because they rely on the current local state of the method 
//(“how many more times is this loop going to run?”).


//Although the async and await keywords offer one solution, it’s sometimes possible to solve it in another way 
//by replacing the imperative looping constructs with the functional equivalent (in other words, LINQ queries). 
//This is the basis of Reactive Extensions (Rx) and can be a good option when you want to execute query operators 
//over the result—or combine multiple sequences. The price to pay is that to prevent blocking, Rx operates over 
//push-based sequences, which can be conceptually tricky.
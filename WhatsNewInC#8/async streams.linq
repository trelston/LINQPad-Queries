<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task Main()
{	
	await foreach (var number in RangeAsync (0, 10))
		Console.WriteLine (number);

	// In LINQPad, you can also just dump the IAsyncEnumerable.
	RangeAsync (0, 10).Dump();
}

public static async IAsyncEnumerable<int> RangeAsync (int start, int count)
{
	for (int i = start; i < start + count; i++)
	{
		await Task.Delay (100);
		yield return i;
	}
}
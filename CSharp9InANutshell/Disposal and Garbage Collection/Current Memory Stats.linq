<Query Kind="Program">
  <Namespace>System.Diagnostics</Namespace>
</Query>

void Main()
{
	long totalMemAllocated = 0;
	for (int i = 0; i < 200; i++)
	{
		totalMemAllocated += AllocatedSomeNonReferencedMemory();
		string procName = Process.GetCurrentProcess().ProcessName;
		using PerformanceCounter pcPB = new PerformanceCounter("Process", "Private Bytes", procName);
		long memoryUsed = GC.GetTotalMemory(false); //Change to true to force a collection before reporting used memory
	}
}

// Define other methods and classes here
long AllocatedSomeNonReferencedMemory()
{
	int loops = 64;
	int size = 1024;

	for (int i = 0; i < loops; i++)
	{
		int[] array = new int[size];
	}

	return loops * size * 4; //int is 32-bits (4 bytes)
}
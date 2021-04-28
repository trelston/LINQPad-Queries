<Query Kind="Statements" />

//A thread is deemed blocked when its execution is paused for some reason, such as when Sleeping or waiting for another to end via Join. 
//A blocked thread immediately yields its processor time slice, and from then on it consumes no processor time until its blocking condition 
//is satisfied. You can test for a thread being blocked via its ThreadState property:

//bool blocked = (someThread.ThreadState & ThreadState.WaitSleepJoin) != 0;

public static class ThreadExtensions
{
	//ThreadState is a flags enum, combining three “layers” of data in a bitwise fashion. 
	//Most values, however, are redundant, unused, or deprecated. 
	//The following extension method strips a ThreadState to one of four useful values: Unstarted, Running, WaitSleepJoin, and Stopped:
	public static System.Threading.ThreadState Simplify(this System.Threading.ThreadState ts)
	{
		return ts & (System.Threading.ThreadState.Unstarted
		| System.Threading.ThreadState.WaitSleepJoin
		| System.Threading.ThreadState.Stopped);
	}

	//The ThreadState property is useful for diagnostic purposes but unsuitable for synchronization, 
	//because a thread’s state can change in between testing ThreadState and acting on that information.
}

//When a thread blocks or unblocks, the OS performs a context switch. This incurs a small overhead, typically one or two microseconds.
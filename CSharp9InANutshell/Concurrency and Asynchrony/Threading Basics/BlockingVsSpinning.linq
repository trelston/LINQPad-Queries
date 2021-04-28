<Query Kind="Statements" />

//An operation that spends most of its time waiting for something to happen is called I/O-bound—an example is downloading a web page 
//or calling Console.ReadLine. (I/O-bound operations typically involve input or output, but this is not a hard requirement: 
//Thread.Sleep is also deemed I/O-bound.) 
//In contrast, an operation that spends most of its time performing CPU-intensive work is called compute-bound.

//An I/O-bound operation works in one of two ways: 
//it either waits synchronously on the current thread until the operation is complete 
//(such as Console.ReadLine, Thread.Sleep, or Thread.Join), or it operates asynchronously, 
//firing a callback when the operation finishes some time later

//I/O-bound operations that wait synchronously spend most of their time blocking a thread. They can also “spin” in a loop periodically
//while (DateTime.Now < nextStartTime)
//	Thread.Sleep(100);
	
//Leaving aside that there are better ways to do this (such as timers or signaling constructs), 
//another option is that a thread can spin continuously
//while (DateTime.Now < nextStartTime);

//In general, this is very wasteful on processor time: as far as the CLR and OS are concerned, 
//the thread is performing an important calculation and thus is allocated resources accordingly. 
//In effect, we’ve turned what should be an I/O-bound operation into a compute-bound operation.


 //Blocking does not incur a zero cost. 
 //This is because each thread ties up around 1 MB of memory for as long as it lives and causes an ongoing administrative overhead 
 //for the CLR and OS. For this reason, blocking can be troublesome in the context of heavily I/O-bound programs 
 //that need to handle hundreds or thousands of concurrent operations. Instead, such programs need to use a callback-based approach, 
 //rescinding their thread entirely while waiting. 

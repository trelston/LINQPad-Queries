<Query Kind="Expression" />

//A thread’s Priority property determines how much execution time it is allotted relative to other active threads in the OS, on the following scale:
// enum ThreadPriority { Lowest, BelowNormal, Normal, AboveNormal, Highest }

//This becomes relevant when multiple threads are simultaneously active. 
//You need to take care when elevating a thread’s priority because it can starve other threads. 
//If you want a thread to have higher priority than threads in other processes, 
//you must also elevate the process priority using the Process class in System.Diagnostics:
using Process p = Process.GetCurrentProcess();
p.PriorityClass = ProcessPriorityClass.High;


//This can work well for non-UI processes that do minimal work and need low latency (the ability to respond very quickly) in the work they do. 
//With compute-hungry applications (particularly those with a user interface), elevating process priority can starve other processes, 
//slowing down the entire computer.
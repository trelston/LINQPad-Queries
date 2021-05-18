<Query Kind="Statements" />

//a lambda expression is the most convenient and powerful way to pass data to a thread. However, 
//you must be careful about accidentally modifying captured variables after starting the thread. 
//For instance, consider the following:
for (int i = 0; i < 10; i++)
	new Thread (() => Console.Write (i)).Start();

//The output is nondeterministic! Here’s a typical result:
//0223557799

//The problem is that the i variable refers to the same memory location throughout the loop’s lifetime. 
//Therefore, each thread calls Console.Write on a variable whose value can change as it is running! 
//The solution is to use a temporary variable as follows:
for (int i = 0; i < 10; i++)
{
	int temp = i;
	new Thread(() => Console.Write(temp)).Start();
}

//Each of the digits 0 to 9 is then written exactly once. (The ordering is still undefined because threads can start at indeterminate times.)

//Variable temp is now local to each loop iteration. Therefore, each thread captures a different memory location and there’s no problem. 
//We can illustrate the problem in the earlier code more simply with the following example:
string text = "t1";
Thread t1 = new Thread(() => Console.WriteLine(text));

text = "t2";
Thread t2 = new Thread(() => Console.WriteLine(text));

t1.Start(); t2.Start();
//Because both lambda expressions capture the same text variable, t2 is printed twice.
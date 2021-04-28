<Query Kind="Statements" />

//Local variables captured by a lambda expression can also be shared:
bool done = false;
ThreadStart action = () =>
{
	if (!done) { done = true; Console.WriteLine ("Done"); }
};
new Thread (action).Start();
action();
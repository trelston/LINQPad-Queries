<Query Kind="Statements" />

//With this approach, you can pass in any number of arguments to the method. 
//You can even wrap the entire implementation in a multistatement lambda
new Thread (() =>
{
	Console.WriteLine ("I'm running on another thread!");
	Console.WriteLine ("This is so easy!");
}).Start();
<Query Kind="Statements" />

//Threads share data if they have a common reference to the same object or variable:
bool _done = false;

new Thread(Go).Start();
Go();

void Go()
{
	if (!_done)
	{
		_done = true;
		Console.WriteLine("Done");
	}
}

//Both threads share the _done variable, so “Done” is printed once instead of twic
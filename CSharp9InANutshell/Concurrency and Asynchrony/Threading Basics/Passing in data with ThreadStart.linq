<Query Kind="Statements" />

//An alternative (and less flexible) technique is to pass an argument into Thread’s Start method

Thread t = new Thread(Print);
t.Start("Hello from t!");

void Print(object messageObj)
{
	string message = (string)messageObj;   // We need to cast here
	Console.WriteLine(message);
}

//This works because Thread’s constructor is overloaded to accept either of two delegates:
//public delegate void ThreadStart();
//public delegate void ParameterizedThreadStart(object obj);
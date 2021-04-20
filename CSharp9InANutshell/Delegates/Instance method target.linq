<Query Kind="Program" />

// When a delegate object is assigned to an instance method, the delegate object must maintain
// a reference not only to the method, but also to the instance to which the method belongs:

void Main()
{
	MyReporter r = new MyReporter();
	r.Prefix = "%Complete ";
	ProgressReporter p = r.ReportProgress;
	p(99); 								//%Complete 99
	
	Console.WriteLine(p.Target == r); 	//True
	Console.WriteLine(p.Method);		//MyReporter.ReportProgress (Int32 percentComplete)
	r.Prefix = "";
	p(99);								//99
	
}

// Define other methods and classes here
public delegate void ProgressReporter(int percentComplete);

class MyReporter
{
	public string Prefix = "";
	public void ReportProgress(int percentComplete) => Console.WriteLine(Prefix + percentComplete);
}
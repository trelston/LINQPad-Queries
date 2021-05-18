<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\wpf\PresentationCore.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\PresentationFramework.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\wpf\PresentationUI.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Xaml.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\wpf\WindowsBase.dll</Reference>
  <Namespace>System.Windows</Namespace>
  <Namespace>System.Windows.Controls</Namespace>
</Query>

//In WPF, UWP, and Windows Forms applications, executing long-running operations on the main thread makes the 
//application unresponsive because the main thread also processes the message loop that performs rendering 
//and handles keyboard and mouse events.

//  popular approach is to start up “worker” threads for time-consuming operations. 
//The code on a worker thread runs a time-consuming operation and then updates the UI when complete. 
//However, all rich client applications have a threading model whereby UI elements and controls can be accessed only from the 
//thread that created them (typically the main UI thread). 
//Violating this causes either unpredictable behavior or an exception to be thrown.

//Hence when you want to update the UI from a worker thread, you must forward the request to the UI thread (the technical term is marshal). 
//The low-level way to do this is as follows (later, we discuss other solutions that build on these):
// - In WPF, call BeginInvoke or Invoke on the element’s Dispatcher object.
// - In UWP apps, call RunAsync or Invoke on the Dispatcher object.
// - In Windows Forms, call BeginInvoke or Invoke on the control.

//All of these methods accept a delegate referencing the method you want to run. 
//BeginInvoke/RunAsync work by enqueuing the delegate to the UI thread’s message queue 
//(the same queue that handles keyboard, mouse, and timer events). 
//Invoke does the same thing but then blocks until the message has been read and processed by the UI thread. 
//Because of this, Invoke lets you get a return value back from the method. 
//If you don’t need a return value, BeginInvoke/RunAsync are preferable in that they don’t block the caller 
//and don’t introduce the possibility of deadlock

//You can imagine that when you call Application.Run, the following pseudo-code executes:
//while (!thisApplication.Ended)
//{
//	wait for something to appear in message queue
//  
//	Got something: what kind of message is it ?
//	  Keyboard / mouse message->fire an event handler
//  
//	  User BeginInvoke message->execute delegate
//  
//	  User Invoke message->execute delegate & post result
//}
//It’s this kind of loop that enables a worker thread to marshal a delegate for execution onto the UI thread.


//To demonstrate, suppose that we have a WPF window that contains a text box called txtMessage, 
//whose content we want a worker thread to update after performing a time-consuming task (which we will simulate by calling Thread.Sleep). 
//Here’s how we’d do it:

void Main()
{
	new MyWindow().ShowDialog();
}

partial class MyWindow : Window
{
	TextBox txtMessage;
	
	public MyWindow()
	{
		InitializeComponent();
		new Thread (Work).Start();
	}
	
	void Work()
	{
		Thread.Sleep (5000);           // Simulate time-consuming task
		UpdateMessage ("The answer");
	}
	
	void UpdateMessage (string message)
	{
		Action action = () => txtMessage.Text = message;
		Dispatcher.BeginInvoke (action);
	}
	
	void InitializeComponent()
	{
		SizeToContent = SizeToContent.WidthAndHeight;
		WindowStartupLocation = WindowStartupLocation.CenterScreen;
		Content = txtMessage = new TextBox { Width=250, Margin=new Thickness (10), Text="Ready" };
	}
}
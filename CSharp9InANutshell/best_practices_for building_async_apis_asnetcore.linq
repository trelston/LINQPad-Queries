<Query Kind="Program">
  <Connection>
    <ID>18dade70-2acc-4a72-9b98-67097ca3c1f3</ID>
    <Persist>true</Persist>
    <Server>(localdb)\MSSQLLocalDB</Server>
    <Database>NorthWind</Database>
  </Connection>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

#region Theory

/*
	The main advantage of writing async code is scalability, not performance.
	
	What is scalability?
	Scalability is the capability of a system, network, or process to handle a growing amount of work,
	or its potential to be enlarged to accomodate that growth.
	
	Growth in this case is the requests coming into our api.
	
	One way of increasing scalability is by writing an API in a way that can accomodate horizontal scaling
	
	Another way of increasing scalability is by writing an API in such a way that resource utilization is improved.
	One way of doing this is to use threads better by trying to process the requests faster.
	
	Writing async code helps with improving the vertical scalability at server level.
	
	Handling synchronous requests:-
	1. A request comes in, a thread is provided from the thread pool to process that request
	2. The webapi code accesses the database(I/O) which means that it is doing nothing, it is blocked
	3. Now a new request comes in, a thread is available on the thread pool, and the same occurs
	4. Now another request comes in, now no threads are available on the thread pool, so the request has to wait
	
	Handling asynchronous requests:-
	1. A request comes in, a thread is provided from the thread pool to process that request
	2. The webapi code accesses the database(I/O) but this time the thread returns to the threadpool
	3. We get a response from the I/O, then another thread from the threadpool processes the response.
	
	The async/await keyword
	Marking a method with the async modifier ensures that the await keyword can be used inside that method
	It transforms the method into a state machine
	
	The await operator tells the compiler that the async method can't continue until the awaited asynchronous process is complete.
	Returns control to the caller of the async method.
	
	A method that is not marked with the async modifier cannot be awaited
	
	When an async method doesn't contain an await operator, the method simply executes as a synchronous method does
	
	
	ASYNC RETURN TYPES
	Task and Task<T> represents a single operation that returns nothing(Task) or a value of type T(Task<T>) and usually
	executes asyncronously.
	It represents the execution of the async method
	Status, IsCanceled, IsCompleted, and IsFaulted properties allow determinig the state of a Task
	Gets the status complete when the method completes (and optionally returns the method value as the Task's result)
	
	This is where the state machine concept comes into the picture.
	Through Task and Task<T> we can know the state of an async operation
	
	This is what happens behind the scenes:-
	Tasks are managed by the state machine generated by the compiler when a method is marked with the async modifier
	
	
	void return type is only advised for event handlers. 
	It is hard to handle exceptions. void async swallows exceptions.
	The calling code has no idea about the status.
	
	I/O Bound VS Computational bound work
	
	Will code be waiting for a task to be complete before continuing? I/O bound
	File system, database, network calls, Server side and client side
	
	Will my code be performing an expensive computation? computational bound work
	Expensive business algorithm
	Don't use async on the server for computational-bound work. Always on the client side
	
	*/

#endregion

async Task Main()
{
	var p = await GetProductAsync(1);
	p.Dump();
}


// Define other methods and classes here
Task<Products> GetProductAsync(int productId)
{
	return Task.FromResult<Products>(Products.First(p => p.ProductID == productId));
}

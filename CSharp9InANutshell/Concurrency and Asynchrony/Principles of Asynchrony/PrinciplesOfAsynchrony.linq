<Query Kind="Expression" />

//A synchronous operation does its work before returning to the caller.

//An asynchronous operation can do (most or all of) its work after returning to the caller.


//What Is Asynchronous Programming?
//The principle of asynchronous programming is that you write long-running (or potentially long-running) functions asynchronously. 
//This is in contrast to the conventional approach of writing long-running functions synchronously, 
//and then calling those functions from a new thread or task to introduce concurrency as required.

//The difference with the asynchronous approach is that concurrency is initiated inside the long-running function rather 
//than from outside the function
// This has two benefits:
// - I/O-bound concurrency can be implemented without tying up threads
// - Rich-client applications end up with less code on worker threads, simplifying thread safety.

//This, in turn, leads to two distinct uses for asynchronous programming. 
//The first is writing (typically server-side) applications that deal efficiently with a lot of concurrent I/O. 
//The challenge here is not thread safety (because there’s usually minimal shared state) but thread efficiency; 
//in particular, not consuming a thread per network request. 
//So, in this context, it’s only I/O-bound operations that benefit from asynchrony.

//The second use is to simplify thread-safety in rich-client applications. 
//This is particularly relevant as a program grows in size, because to deal with complexity, 
//we typically refactor larger methods into smaller ones, resulting in chains of methods that call one another (call graphs).

//With a traditional synchronous call graph, if any operation within the graph is long-running, we must run the entire 
//call graph on a worker thread to maintain a responsive UI. 
//Hence, we end up with a single concurrent operation that spans many methods (coarse-grained concurrency), 
//and this requires considering thread-safety for every method in the graph.

//With an asynchronous call graph, we need not start a thread until it’s actually needed, typically low in the graph 
//(or not at all in the case of I/O-bound operations). 
//All other methods can run entirely on the UI thread, with much-simplified thread safety. 
//This results in fine-grained concurrency—a sequence of small concurrent operations, between which execution bounces to the UI thread.

//The UWP framework encourages asynchronous programming to the point where synchronous versions of some long-running methods are either
//not exposed or throw exceptions. Instead, you must call asynchronous methods that return tasks (or objects that can be converted 
//into tasks via the AsTask extension method).
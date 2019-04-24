<Query Kind="FSharpProgram" />

//Checklist to convert to async
//1 - Place the body in an async {}
//2 - Identify any time consuming external operation where the API you are using offers an Async version
//3 - Use let! or do! to bind or imperatively execute them. Where necessary, use Async.AwaitTask to translate
//      from a C# task to F# async
//4 - Return (the promise of) results using the return keyword



//C# Task versus F# Async
//C# uses a "hot task" model: when something creates a Task instance, the underlying computation is already running
//F# uses a "cold task" model: the caller is responsible for starting the computation
//When coding in F#
//1 - When an API returns a C# task, convert it to an F# Async using Async.AwaitTask if you want to use it in 
//      an async computation expression with let! and do!
//2 - If you are writing an API, you should by default return a C# task. You can work internally in terms of F# async
//      and at the last moment convert into a C# task using Async.StartAsTask.
//3 - API functions that return a C# Task should be named with a suffix of Async eg. DownloadFileTaskAsync
//4 - F# centric APIs that return an F# Async should be named with a prefix of Async eg. HtmlDocument.AsyncLoad


//Overloads for exposing C# task
//type NiceCSharp =
//  static member AsyncSomeWork(...) =
//      Async.StartAsTask(someWork(...))
//  static member AsyncSomeWork(cancellationToken) =
//      Async.StartAsTask(someWork(...), cancellationToken = cancellationToken)

//Learn more F# Async
// "F# Async Guide" by Lev Gorodinski (of Jet.com)
// "Hopac" - concurrent programming library for F# in the style of Concurrent ML.

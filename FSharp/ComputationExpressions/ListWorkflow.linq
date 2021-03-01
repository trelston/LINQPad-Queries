<Query Kind="FSharpProgram" />

type ListWorkflowBuilder() =

    member this.Bind(list, f) = 
        list |> List.collect f 
    
    member this.Return(x) = 
        [x]
        
    member this.Zero() = 
        printfn "Zero"
        []
    
    member this.YieldFrom(m) = 
        printfn "Yield a list (%A) directly" m
        m
    
    member this.Yield(x) = 
        printfn "Yield an unwrapped %A as a list" x
        [x]
        
    member this.For(list, f) = 
        this.Bind(list, f)
        
    member this.Combine (a,b) = 
        printfn "combining %A and %A" a b 
        List.concat [a;b]

    member this.Delay(f) = 
        printfn "Delay"
        f()

let listWorkflow = new ListWorkflowBuilder()

let added = 
    listWorkflow {
        let! i = [1;2;3]
        let! j = [10;11;12]
        return i+j
        }
printfn "added=%A" added

let multiplied = 
    listWorkflow {
        let! i = [1;2;3]
        let! j = [10;11;12]
        return i*j
        }
printfn "multiplied=%A" multiplied 

let multiplied2 = 
    listWorkflow {
        for i in [1;2;3] do
        for j in [10;11;12] do
        return i*j
        }
printfn "multiplied=%A" multiplied 

Dump("Introducing Yield") |> ignore

listWorkflow { 
    yield 1
    yield 2
    } |> printfn "Result for yield then yield: %A" 

listWorkflow { 
    yield 1
    yield! [2;3]
    } |> printfn "Result for yield then yield! : %A" 
    
listWorkflow { 
    for i in ["red";"blue"] do
        yield i
        for j in ["hat";"tie"] do
            yield! [i + " " + j;"-"]
    } |> printfn "Result for for..in..do : %A"


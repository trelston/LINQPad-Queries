<Query Kind="FSharpProgram">
  <NuGetReference>NUnit</NuGetReference>
</Query>

open System
open Microsoft.FSharp.Reflection
open Microsoft.FSharp.Quotations
open Microsoft.FSharp.Quotations.Patterns

//Evaluates a useful subset of F# quotations at run-time (without the F# PowerPack API).

//Evaluates expression untyped
let rec eval = function
    | Value(v,t) -> v
    | Coerce(e,t) -> eval e
    | NewObject(ci,args) -> ci.Invoke(evalAll args)
    | NewArray(t,args) ->
        let array = Array.CreateInstance(t, args.Length)
        args |> List.iteri(fun i arg -> array.SetValue(eval arg,i))
        box array
    | NewUnionCase(case,args) -> FSharpValue.MakeUnion(case, evalAll args)
    | NewRecord(t, args) -> FSharpValue.MakeRecord(t, evalAll args)
    | NewTuple(args) ->
        let t = FSharpType.MakeTupleType [|for arg in args -> arg.Type|]
        FSharpValue.MakeTuple(evalAll args, t)
    | FieldGet(Some(Value(v,_)), fi) -> fi.GetValue(v)
    | PropertyGet(None, pi, args) -> pi.GetValue(null, evalAll args)
    | PropertyGet(Some(x),pi, args) -> pi.GetValue(eval x, evalAll args)
    | Call(None,mi,args) -> mi.Invoke(null, evalAll args)
    | Call(Some(x),mi,args) -> mi.Invoke(eval x, evalAll args)
    | arg -> raise <| NotSupportedException(arg.ToString())
and evalAll args = [|for arg in args -> eval arg |]

open NUnit.Framework

type Tests() = 
    static member Expressions =
        let (==) quote value = TestCaseData([|quote|]).Returns(value)
        [
        <@ 1 @> == 1
        <@ 1 + 1 @> == 2
        <@ 2 * 2 @> == 4
        <@ 9.9M @> == 9.9M
        <@ "Hello World" @> == "Hello World"
        <@ [1;2;3] @> == [1;2;3]
        <@ [|1;2;3|] @> == [|1;2;3|]
        <@ (1,2,3) @> == (1,2,3)
        <@ Some(1) @> == Some(1)
        <@ {Name="Phil"; Age=27} @> == {Name = "Phil"; Age=27}
        <@ PersonClass("Phil", 27) @> == PersonClass("Phil", 27)
        ]
        
    [<Test;TestCaseSource("Expressions")>]
    static member ``evaluates`` (expr:Expr) = eval expr
    
    member test.LocalProperty = 1
    
    [<Test>]
    member test.``local property getter`` () =
        Assert.AreEqual(test.LocalProperty, eval <@test.LocalProperty @>)
        
    member test.LocalMethod() = 1
    
    [<Test>]
    member test.``local property method`` () =
        Assert.AreEqual(test.LocalMethod(), eval <@ test.LocalMethod() @>)
        
    static member GlobalProperty = 1
    
    [<Test>]
    member test.``global property getter`` () =
        Assert.AreEqual(Tests.GlobalProperty, eval <@Tests.GlobalProperty@>)
        
    static member GlobalMethod() = 1
    
    [<Test>]
    member test.``global property method`` () =
        Assert.AreEqual(Tests.GlobalMethod(), eval <@ Tests.GlobalMethod() @>)
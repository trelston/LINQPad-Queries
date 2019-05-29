<Query Kind="FSharpProgram" />

//A sample that translates simple F# quotations(method calls, property getters) to standard C# LINQ expression trees
open System
open System.Linq.Expressions
open Microsoft.FSharp.Quotations
open Microsoft.FSharp.Quotations.Patterns

//Translates simple F# quotation to LINQ expression
//(the function supports only variables, property getters,
//method calls and static mehtod calls)
let rec translateSimpleExpr expr = 
    match expr with
    | Var(var) ->
        //Variable access
        Expression.Variable(var.Type, var.Name) :> Expression
    | PropertyGet(Some inst, pi, []) ->
        //Getter of an instance property
        let instExpr = translateSimpleExpr inst
        Expression.Property(instExpr, pi) :> Expression
    | Call(Some inst, mi, args) ->
        //Method call - translate instance & arguments recursively
        let argsExpr = Seq.map translateSimpleExpr args
        let instExpr = translateSimpleExpr inst
        Expression.Call(instExpr, mi, argsExpr) :> Expression
    | Call(None, mi, args) ->
        //Static method call - no instance
        let argsExpr = Seq.map translateSimpleExpr args
        Expression.Call(mi, argsExpr) :> Expression
    | _ -> failwith "not supported"
    
    
//Translates a simple F# quotation to a lambda expression
let translateLambda (expr:Expr<'T -> 'R>) =
    match expr with
    | Lambda(v, body) ->
        //Build LINQ style lambda expression
        let bodyExpr = translateSimpleExpr body
        let paramExpr = Expression.Parameter(v.Type, v.Name)
        Expression.Lambda<Func<'T, 'R>>(paramExpr)
    | _ -> failwith "not supported"
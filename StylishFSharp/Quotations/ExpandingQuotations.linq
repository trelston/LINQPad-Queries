<Query Kind="FSharpProgram" />

//The snippet implements a function "expand" that takes a quotation and performs two operations.
//It replaces all calls to methods marked with ReflectedDefinition with the body of the method and it simplifies all expressions
// that can be reduced in call-by-name style (let binding & application of lambda)

open Microsoft.FSharp.Quotations

//The parameter 'vars' is an immutable map that assigns expressions to variables
//(as we recursively process the tree, we replace all known variables)
let rec expand vars expr =
    
    //First recursively process & replace variables
    let expanded =
        match expr with
        //If the variable has an assignment, then replace it with the expression
        | ExprShape.ShapeVar v when Map.containsKey v vars -> vars.[v]
        //Apply 'expand' recursively on all sub-expressions
        | ExprShape.ShapeVar v -> Expr.Value
    
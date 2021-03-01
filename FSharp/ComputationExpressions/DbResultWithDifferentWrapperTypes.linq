<Query Kind="FSharpProgram" />

type DbResult<'a> = 
    | Success of 'a
    | Error of string

type CustomerId =  CustomerId of string
type OrderId =  OrderId of int
type ProductId =  ProductId of string

let getCustomerId name =
    if (name = "") 
    then Error "getCustomerId failed"
    else Success (CustomerId "Cust42")

let getLastOrderForCustomer (CustomerId custId) =
    if (custId = "") 
    then Error "getLastOrderForCustomer failed"
    else Success (OrderId 123)

let getLastProductForOrder (OrderId orderId) =
    if (orderId  = 0) 
    then Error "getLastProductForOrder failed"
    else Success (ProductId "Product456")

let product = 
    let r1 = getCustomerId "Alice"
    match r1 with 
    | Error e -> Error e
    | Success custId ->
        let r2 = getLastOrderForCustomer custId 
        match r2 with 
        | Error e -> Error e
        | Success orderId ->
            let r3 = getLastProductForOrder orderId 
            match r3 with 
            | Error e -> Error e
            | Success productId ->
                printfn "Product is %A" productId
                r3


type DbResultBuilder() =

    member this.Bind(m, f) = 
        match m with
        | Error e -> Error e
        | Success a -> 
            printfn "\tSuccessful: %A" a
            f a

    member this.Return(x) = 
        Success x

let dbresult = new DbResultBuilder()


let product' = 
    dbresult {
        let! custId = getCustomerId "Alice"
        let! orderId = getLastOrderForCustomer custId
        let! productId = getLastProductForOrder orderId 
        printfn "Product is %A" productId
        return productId
        }
printfn "%A" product'


let product'' = 
    dbresult {
        let! custId = getCustomerId "Alice"
        let! orderId = getLastOrderForCustomer (CustomerId "") //error
        let! productId = getLastProductForOrder orderId 
        printfn "Product is %A" productId
        return productId
        }
printfn "%A" product''



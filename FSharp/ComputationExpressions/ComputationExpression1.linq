<Query Kind="FSharpProgram" />

let strToInt str = 
    match Int32.TryParse(str) with
    | (true, i) -> Some i
    | (false,_) -> None      

type MyWorkflowBuilder() =
        member this.Bind(m, f) = Option.bind f m
        member this.Return(x) = Some x

let yourWorkflow = new MyWorkflowBuilder()

let stringAddWorkflow x y z = 
    yourWorkflow 
        {
        let! a = strToInt x
        let! b = strToInt y
        let! c = strToInt z
        return a + b + c
        }    

let good = (stringAddWorkflow "12" "3" "2")
let bad = stringAddWorkflow "12" "xyz" "2"

good.Dump()
bad.Dump()


let strAdd str i =
   str 
   |> strToInt
   |> Option.map ((+) i)
   
let (>>=) m f = Option.bind f m

let good1 = strToInt "1" >>= strAdd "2" >>= strAdd "3"
let bad1 = strToInt "1" >>= strAdd "xyz" >>= strAdd "3"
   
good1.Dump()
bad1.Dump()


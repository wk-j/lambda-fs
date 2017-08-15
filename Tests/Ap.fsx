open System

#load "../Source/R.fsx"

let fs = [(*) 10; (+) 2] 
let input = [1;2;3] 

R.ap fs input |> printfn "%A"

let fs2 = [(+) "Hello"; (+) "!"] 
R.ap fs2 ["a"; "b"] |> printfn "%A"

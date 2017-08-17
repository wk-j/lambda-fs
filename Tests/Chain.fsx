#load "../Source/R.fsx"

let dup x = [x;x]

R.chain dup [1;2;3;4] |> printfn "%A"


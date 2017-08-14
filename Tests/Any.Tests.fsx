#load "../Source/Any.fsx"

Any.any (fun x -> x = 5) [1;2;3;4;5] = true     |> printfn "%A"
Any.any (fun x -> x = 0) [1;2;3;4;5] = false    |> printfn "%A"
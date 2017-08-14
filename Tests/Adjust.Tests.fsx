#load "../Source/Adjust.fsx"
Adjust.adjust ((+) 10) 1 [1;2;3;4] |> printfn "%A"
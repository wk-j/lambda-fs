#load "../Source/R.fsx"


R.apply Seq.sum [1;2;3;4;5] |> printfn "%A"
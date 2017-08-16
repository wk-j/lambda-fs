#load "../Source/R.fsx"

R.applySpec [(+) 5; (+) 10] [5;5] |> printfn "%A"
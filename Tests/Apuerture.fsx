#load "../Source/R.fsx"

R.aperture 2 [1;2;3;4;5] |> printfn "%A"
R.aperture 3 [1;2;3;4;5] |> printfn "%A"
R.aperture 7 [1;2;3;4;5] |> printfn "%A"
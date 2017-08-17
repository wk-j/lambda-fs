#load "../Source/R.fsx"

R.concat [["A"; "B"]; ["B"]] |> printfn "%A"
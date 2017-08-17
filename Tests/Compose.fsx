#load "../Source/R.fsx"

let greet (f, l) = "The name's " + f + ", " + l
let toUpper s = (s: string).ToUpper()

let rs = R.compose greet toUpper

rs ("Wk", "Wk") |> printfn "%A"
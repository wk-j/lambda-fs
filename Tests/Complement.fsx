#load "../Source/R.fsx"

let notNull = R.complement isNull
notNull ""      |> printfn "%A"
notNull null    |> printfn "%A"

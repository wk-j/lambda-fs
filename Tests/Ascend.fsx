#load "../Source/R.fsx"


type Person = { Age : int }

let assend = R.ascend (fun x -> x.Age)

let ls = 
    [ { Age = 10 }
      { Age = 20 }
      { Age = 15 }]

List.sortBy assend ls |> printfn "%A"
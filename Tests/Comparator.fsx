#load "../Source/R.fsx"

type A = { X : int ; Y : int }
let ls = [
    { X = 100; Y = 100 }
    { X = 200; Y = 100 }
    { X = 300; Y = 100 }
]

let comp = R.comparator (fun (a,b) -> a.X < b.X)

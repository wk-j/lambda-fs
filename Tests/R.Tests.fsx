#load "../Source/R.fsx"

R.add 1 2 = 3 |> printfn "%A"

R.addIndexed [1;2;3;4] |> printfn "%A"
R.adjust ((+) 10) 1 [1;2;3;4] |> printfn "%A"

R.all ((=) 200) [200; 200; 200] |> printfn "%A"
R.all ((=) 200) [200; 200; 300] |> printfn "%A"

R.allPass [(fun x -> x > 0); (fun x -> x < 10)] 5 |> printfn "%A"
R.allPass [(fun x -> x > 0); (fun x -> x < 10)] 100 |> printfn "%A"

let v = R.always("")
obj.ReferenceEquals(v(), v()) |> printfn "%A"

R.and' true true  = true 
|> printfn "%A"

R.and' false true = false  
|> printfn "%A"   

R.any (fun x -> x = 5) [1;2;3;4;5] = true     |> printfn "%A"
R.any (fun x -> x = 0) [1;2;3;4;5] = false    |> printfn "%A"

R.anyPass [(fun x -> x = 100); (fun x -> x = 200)]  200 = true    |> printfn "%A"
R.anyPass [(fun x -> x = 100); (fun x -> x = 200)]  100 = true    |> printfn "%A"
R.anyPass [(fun x -> x = 200); (fun x -> x = 200)]  100 = false   |> printfn "%A"

// The Secret Rules of Modern Living: Algorithms
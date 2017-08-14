#load "../Source/AnyPass.fsx"

AnyPass.anyPass [(fun x -> x = 100); (fun x -> x = 200)]  200 = true    |> printfn "%A"
AnyPass.anyPass [(fun x -> x = 100); (fun x -> x = 200)]  100 = true    |> printfn "%A"
AnyPass.anyPass [(fun x -> x = 200); (fun x -> x = 200)]  100 = false   |> printfn "%A"
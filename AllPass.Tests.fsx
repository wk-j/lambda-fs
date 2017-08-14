#load "./AllPass.fsx"

AllPass.allPass [(fun x -> x > 0); (fun x -> x < 10)] 5 |> printfn "%A"
AllPass.allPass [(fun x -> x > 0); (fun x -> x < 10)] 100 |> printfn "%A"

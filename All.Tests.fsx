#load "./All.fsx"

All.all ((=) 200) [200; 200; 200] |> printfn "%A"
All.all ((=) 200) [200; 200; 300] |> printfn "%A"

#load "../Source/Always.fsx"

let v = Always.always("")
obj.ReferenceEquals(v(), v()) |> printfn "%A"
#load "../Source/And.fsx"

And.and' true true  = true 
|> printfn "%A"

And.and' false true = false  
|> printfn "%A"    

let inline add x y = x + y

let addIndexed input = Seq.indexed input

let adjust (f: 'a -> 'a) index (input: 'a list) =  
    [for i, x in Seq.indexed input do
        if i = index then
            yield f(x)
        else
            yield x ]
let all (f: 'a -> bool) (input: 'a list) = 
    Seq.forall f input
    
let allPass (predicate : ('a -> bool) list) (input: 'a) = 
    predicate |> Seq.forall (fun f -> f input)
    
let always (a:'a) = (fun () -> a)

let and' a b = a && b

let any f (input: 'a seq) = Seq.exists f input

let anyPass (f: ('a -> bool) seq) (input: 'a) = 
    f |> Seq.exists (fun x -> x(input))
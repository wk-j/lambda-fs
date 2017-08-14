let allPass (predicate : ('a -> bool) list) (input: 'a) = 
    predicate |> Seq.forall (fun f -> f input)
let anyPass (f: ('a -> bool) seq) (input: 'a) = 
    f |> Seq.exists (fun x -> x(input))
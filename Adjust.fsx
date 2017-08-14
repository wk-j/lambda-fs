let adjust (f: 'a -> 'a) index (input: 'a list) =  
    [for i, x in Seq.indexed input do
        if i = index then
            yield f(x)
        else
            yield x ]

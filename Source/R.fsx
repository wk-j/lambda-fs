let inline add x y = x + y

let addIndexed xs = Seq.indexed xs

let adjust (f: 'a -> 'a) index (xs: 'a seq) =  
    [for i, x in Seq.indexed xs do
        if i = index then 
            yield f(x)
        else 
            yield x]

let all (f: 'a -> bool) (xs: 'a seq) = 
    Seq.forall f xs
    
let allPass (ps : ('a -> bool) seq) (x: 'a) = 
    ps |> Seq.forall (fun f -> f x)
    
let always (a:'a) = (fun () -> a)

let and' a b = a && b

let any f (xs: 'a seq) = Seq.exists f xs

let anyPass (fs: ('a -> bool) seq) (xs: 'a) = 
    fs |> Seq.exists (fun x -> x xs)

let ap (fs : ('a -> 'a) seq)  (xs : 'a seq) = 
    xs |> Seq.map (fun x -> Seq.fold (fun a f ->  f a) x fs)

let aperture n xs = 
    let len = Seq.length xs
    if n > len then 
        Seq.empty
    else
        seq { 
            for e in [0 .. len - n] do 
                yield xs |> Seq.skip e |> Seq.take n 
        }

let append x xs = Seq.append xs [x]

let apply f xs = f xs

let applySpec (specs: ('a -> 'b) seq)  (xs: 'a seq) = 
    if (Seq.length specs <> Seq.length xs) then Seq.empty
    else
        Seq.map2 (fun f x -> f x) specs xs



open Microsoft.FSharp.Quotations
open Microsoft.FSharp.Quotations.Patterns

type DynamicMember<'t, 'u> = Expr<'t -> 'u>

let getValueReader (expr : DynamicMember<'recdT, 'fieldT>) = 
    match expr with
    | Lambda(v, PropertyGet (Some (Var v'), pi, [])) when v = v' ->
        let rdr = Reflection.FSharpValue.PreComputeRecordFieldReader pi
        ((box >> rdr >> unbox) : 'recdT -> 'fieldT)
    | _ ->
        failwith "Invalid expression - not reading file"

type SampleRec = { Str : string ; Num : int }
let readStrField = getValueReader <@ fun (r : SampleRec) -> r.Str @>
let readNumFile = getValueReader <@ fun (r : SampleRec) -> r.Num @>

let rc = { Str = "Hello world"; Num = 42}
//let s, n = readStrField rc, readNumFile rc
//printfn "%A %A" s n

let inline getValue<'a> f s = 
    let reader = getValueReader <@ (f) @>
    reader s

let getValue2<'a> f (rc: 'a) =
     let reader = Reflection.FSharpValue.PreComputeRecordFieldReader((typeof<'a>).GetProperty(f))
     reader rc

let getV = getValue2<SampleRec> "Str"
getV rc |> printfn "%A"




// https://stackoverflow.com/questions/9248767/can-f-quotations-be-used-to-create-a-function-applicable-to-arbitrary-f-record
open Microsoft.FSharp.Reflection
open System

let applyOnFields (recd1:'T) (recd2:'T) f =  
  let flds1 = FSharpValue.GetRecordFields(recd1)  
  let flds2 = FSharpValue.GetRecordFields(recd2)  
  let flds = Array.zip flds1 flds2 |> Array.map f
  FSharpValue.MakeRecord(typeof<'T>, flds)

type R = { X : string ; Y : string } 
let  a = { X = null ; Y = "##" } 
let  b = { X = "##" ; Y = null } 

let selectNotNull (x:obj, y) =
  if String.IsNullOrWhiteSpace (unbox x) then y else x

let c = applyOnFields a b selectNotNull 
printfn "%A" c
#r "../packages/Expecto/lib/net461/Expecto.dll"
#load "../Source/R.fsx"

open Expecto

let tests = 
    testList "Tests " [
        test "add" {
            Expect.equal 4 (R.add 2 2) ""
        }

        test "addIndexed" {
            let r = R.addIndexed [1;2;3;4] 
            let e = [(1,0); (2,1); (3,2); (4,3)] |> List.toSeq
            Expect.equal e r ""
        }

        test "adjust" {
            let r = R.adjust ((+) 10) 1 [1;2;3;4] 
            let e = [1;20;3;4]
            Expect.equal e r ""
        }

        test "all" {
            let r1 = R.all ((=) 200) [200; 200; 200] 
            Expect.equal true r1 ""
        }

        test "allPass" {
            let r = R.allPass [(fun x -> x > 0); (fun x -> x < 10)] 5 
            Expect.equal true r ""
        }

        test "always" {
            let v = R.always("")
            let r = obj.ReferenceEquals(v(), v()) 
            Expect.equal true r ""
        }

        test "and" {
            let r = R.and' true true
            Expect.equal true r  ""
        }

        test "any" {
            let r = R.any (fun x -> x = 5) [1;2;3;4;5]
            Expect.equal true r ""
        }

        test "anyPass" {
            let r = R.anyPass [(fun x -> x = 100); (fun x -> x = 200)]  200 
            Expect.equal true r ""
        }
    ]

runTests defaultConfig tests
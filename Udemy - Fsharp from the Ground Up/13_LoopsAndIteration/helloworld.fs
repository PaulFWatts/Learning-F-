(*  Traditional `For` loop iterating with `Array.iter library function` 
    Comments can be passed from the CLI. Launch.json has been
    pre-loaded with 3 arguments
*)
open System

let sayHello person =
    printfn "Hello %s from my F# program!"  person

[<EntryPoint>]
let main argv =
    Array.iter sayHello argv
    printfn "Nice to meet you."
    0

(*  Traditional `For` loop using an iterator 
    Comments can be passed from the CLI. Launch.json has been
    pre-loaded with 3 arguments
*)


open System

[<EntryPoint>]
let main argv =
    for person in argv do
        printfn "Hello %s from my F# program!" person
    printfn "Nice to meet you."
    0



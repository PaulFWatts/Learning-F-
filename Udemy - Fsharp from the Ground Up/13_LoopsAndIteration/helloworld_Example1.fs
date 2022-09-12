(*  Traditional `For` loop without using an iterator 
    Comments can be passed from the CLI. Launch.json has been
    pre-loaded with 3 arguments
*)


open System

[<EntryPoint>]
let main argv =
    for i in 0..argv.Length-1 do
        let person = argv.[i]
        printfn "Hello %s from my F# program!" person
    printf "Nice to meet you."
    0



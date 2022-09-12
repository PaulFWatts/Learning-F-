open System

let sayHello person =
    printfn "Hello %s from my F# program!" person

// Remove any args with spaces, tabs or nulls
let isValid person =
    String.IsNullOrWhiteSpace person |> not

// Remove anyone named Eve
let isAllowed person =
    person <> "Eve"

[<EntryPoint>]
let main argv =
    argv    
    |> Array.filter isValid 
    |> Array.filter isAllowed
    |> Array.iter sayHello
    printfn "Nice to meet you."
    0

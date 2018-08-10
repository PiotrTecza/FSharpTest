module Test
open Code

[<EntryPoint>]
let main argv =
    let p1 = {X = 3; Y = 0}
    let p2 = {X = -1; Y = 0}
    let cos = cos p1 p2
    0


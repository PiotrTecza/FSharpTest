module Test
open Code

[<EntryPoint>]
let main argv =
    let p1 = {X = 0; Y = 0}
    let p2 = {X = 1; Y = 0}
    let p3 = {X = 1; Y = 1}
    let p4 = {X = 0; Y = 1}
    let points = [p1; p2; p3; p4]
    let res = grahamScan points
    0


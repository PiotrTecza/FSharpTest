module Test
open Code
open System

[<EntryPoint>]
let main argv =
    let p1 = {X=1; Y=1; Dist = 0.0; Angle = 0.0}
    let p2 = {p1 with X = 2; Y = 5}
    let p3 = {p1 with X = 3; Y = 3}
    let p4 = {p1 with X = 5; Y = 3}
    let p5 = {p1 with X = 3; Y = 2}
    let p6 = {p1 with X = 2; Y = 2}

    let points = [p1;p2;p3;p4;p5;p6]

    let res = grahamScan points

    // let list =
    //     [
    //      let mutable key = Console.ReadLine()
    //      while (key <> null) do
    //         yield key.Split(' ') |> (fun x -> {X = int x.[0]; Y = int x.[1]; Dist = -1.0; Angle = -1.0})
    //         key <- Console.ReadLine()
    //     ]
    0


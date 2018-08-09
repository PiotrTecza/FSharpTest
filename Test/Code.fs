module Code
open System.Collections.Generic

type Point = { X: int; Y: int; }

let ccw p1 p2 p3 = (p2.X - p1.X)*(p3.Y - p1.Y) - (p2.Y - p1.Y)*(p3.X - p1.X)

let findMin points =
    let mutable min = points |> Seq.head
    for p in points do
        if(p.Y < min.Y || (p.Y = min.Y && p.X < min.X)) then
            min <- p
    min

let dist (p1,p2) = 
    pown (p2.X-p1.X) 2 + pown (p2.Y-p1.Y) 2
    |> float
    |> sqrt

let perimeter points = List.sumBy dist (points |> List.pairwise)
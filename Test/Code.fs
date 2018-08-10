module Code
open System.Collections.Generic

type Point = { X: int; Y: int; }

let ccw p1 p2 p3 = (p2.X - p1.X)*(p3.Y - p1.Y) - (p2.Y - p1.Y)*(p3.X - p1.X)

let findMin points =
    let mutable min = points |> List.head
    for p in points do
        if(p.Y < min.Y || (p.Y = min.Y && p.X < min.X)) then
            min <- p
    min

let dist (p1,p2) = 
    pown (p2.X-p1.X) 2 + pown (p2.Y-p1.Y) 2
    |> float
    |> sqrt

let cos p1 p2 = 
    match p1 = p2 with
    | true -> 2.0
    | false ->
        let x = float p2.X
        let r =
            pown p2.X 2 + pown (p2.Y - p1.Y) 2
            |> float
            |> sqrt
        x/r

let perimeter (points:Point list) = 
    let matrix = points @ [List.head points]
    List.sumBy dist (matrix |> List.pairwise)

let grahamScan points =
    let stack = Stack<Point>()
    let min = findMin points
    let sorted = List.sortByDescending (cos min) points
    let mutable counter = 0
    for point in sorted do
        match counter < 3 with
        | true -> 
            counter <- counter + 1
            stack.Push point
        | false -> 
            let mutable top = stack.Pop()
            let mutable top2 = stack.Pop()
            while ccw top2 top point <= 0 do
                top <- top2
                top2 <- stack.Pop()
            stack.Push top2
            stack.Push top
            stack.Push point
    let stackList = List.ofSeq stack
    perimeter stackList

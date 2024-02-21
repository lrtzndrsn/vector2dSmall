open System
open vec2d

let (=~) (a: float) (b:float) : bool =
    a + 0.00001 > b && a - 0.00001 < b


printfn "Black-box test of vec2dSmall"
printfn "Test of len-function"
printfn " %5b: x = 0, y = 0 (Both values are 0)" (len (0.0, 0.0) = (0.0))
printfn " %5b: x > 0, y > 0 (Both values are positive)" (len (3.0, 4.0) = (5.0))
printfn " %5b: x < 0, y < 0 (Both values are negative)" (len (-3.0, -4.0) = (5.0))
printfn " %5b: x > 0, y < 0 (Only one of the values are negative)" (len (-3.0, 4.0) = (5.0))

printfn "Test of add-function"

printfn " %5b: x2, y2, x3, y3 = 0 (All values are 0)" (add (0.0, 0.0) (0.0, 0.0) = (0.0, 0.0))
printfn " %5b: x2, y2, x3, y3 > 0 (All values are positive)" (add (3.0, 4.0) (4.0, 5.0) = (7.0, 9.0))
printfn " %5b: x2, y2, x3, y3 < 0 (All values are negative)" (add (-3.0, -4.0) (-4.0, -5.0) = (-7.0, -9.0))
printfn " %5b: x2 + x3 < 0, y 2 + y3 > 0 (Vector (x2,y2) has a negative value)" (add (-3.0, 4.0) (4.0, 5.0) = (1.0, 9.0))
printfn " %5b: x2 + x3 > 0, y 2 + y3 > 0 (Vector (x2,y2) is zero vector)" (add (0.0, 0.0) (4.0, 5.0) = (4.0, 5.0))
printfn " %5b: x2 + x3 = 0, y 2 + y3 > 0 (Both vectors are vertical)" (add (0.0, 5.0) (0.0, 7.0) = (0.0, 12.0))
printfn " %5b: x2 + x3 = 0, y 2 + y3 < 0 (Both vectors are vertical, one vector is negatively vertical)" (add (0.0, 5.0) (0.0, -7.0) = (0.0, -2.0))
printfn " %5b: x2 + x3 > 0, y 2 + y3 = 0 (Both vectors are horizontal)" (add (5.0, 0.0) (6.0, 0.0) = (11.0, 0.0))
printfn " %5b: x2 + x3 < 0, y 2 + y3 = 0 (Both vectors are horizontal, one vector is negatively horizontal)" (add (5.0, 0.0) (-6.0, 0.0) = (-1.0, 0.0))
printfn " %5b: x2 + x3 > 0, y 2 + y3 > 0 (Vectors are ortogonal)" (add (-3.0, 4.0) (4.0, 3.0) = (1.0, 7.0))





printfn "Test of ang-function"
printfn " %5b: x1, y1 > 0 (Both values are positive)" (ang (20.0, 30.0) =~ (0.982793723247))
printfn " %5b: x1, y1 < 0 (Both values are negative)" (ang (-20.0, -30.0) =~ (-2.1587989303427))
printfn " %5b: x1 < 0, y1 > 0 (Only one value is positive)" (ang (-20.0, 30.0) =~ (2.158798930342))

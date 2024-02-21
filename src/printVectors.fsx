let v = (1.3, -2.5)
printfn "Vector %A: (%f, %f)" v (vec2dSmall.len v) (vec2dSmall.ang v)
let w = (-0.1 , 0.5)
printfn "Vector %A: (%f, %f)" w (vec2dSmall.len w) (vec2dSmall.ang w)
let s = vec2dSmall.add v w
printfn "Vector %A: (%f, %f)" s (vec2dSmall.len s) (vec2dSmall.ang s)

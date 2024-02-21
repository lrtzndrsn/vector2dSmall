module vec2d

let len ((x, y) : float * float) : float =
    sqrt(x * x + y * y)

let ang ((x1, y1) : float * float) : float =
    atan2 y1 x1

let add ((x2, y2) : float * float) ((x3, y3) : float * float) : float * float  =
    (x2 + x3, y2 + y3)

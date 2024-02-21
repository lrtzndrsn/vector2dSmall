/// A 2 dimensional vector library.
/// Vectors are represented as pairs of floats
module vec2d

/// The length of a vector
///<summary> The function finds the length of a vector from the two vector coordinas (x,y) <\summary>
///<param name = "x, y", accepts any floating point number.<\param>
///<returns> Returns the length of the vector as a float. .<\return>
val len : float * float -> float

/// The angle of a vector
///<summary> Finds the angle of between the vector and the x-asis by the two vector coordinates,(x1,y2) <\summary>
///<param name = "x1, y2", accepts any floating point number.<\param>
///<returns> Returns the angle of the vector as a float. .<\return>
val ang : float * float -> float

/// Addition of two vectors

///<summary> Performs addition of two vectors by adding the two vectors together. It does so by adding the x values and y values together respectively. <\summary>
///<param name = "(x2, y2), (x3, y3)". The first vector pair is defined as (x2,y2). The second vector pair is defined as (x3, y3). They both accept any floating point number.<\param>
///<returns> Returns a new vector that is the addition of vector (x2,y2) and vector (x3,y3) .<\return>
val add : float * float -> float * float -> float * float

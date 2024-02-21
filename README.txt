## Read me 

## About:
This is a simple program that computes vector angle, length and addition.

The three functions are tested using blackbox testing. 

This work was conducted in 2021. 

## How to run the code: 
1. Open a cmd, e.g. mono cmd. 
2. Locate the files vec2dSmall.fsi, vec2dSmall.fs, 4i1.fsx and 4i2.fsx in the src-folder. 
Vec2dSmall.fsi is the signaturefile
Vec2dSmall.fsx is the implementation file
4i1.fsx is the blackbox-test file
4i2.fsx is the application file 
3. When these file has been located in the folder, type in "fsharpc -a vec2dSmall.fsi vec2dSmall.fs". This will make fsharp enter compile mode. 
4. When this is done correctly, a dll file will be generated. And you can run the blackbox test or the application file. 

To run the blackboxtest:
5. Type in "fsharpc -r vec2dSmall.dll 4i1.fsx after you have completed step 3. This will create an .exe file
6. Now type in "mono 4i1.exe" to run the code. 

To run the application file: 
7. Type in "fsharpc -r vec2dSmall.dll 4i2.fsx are you have completed step 3. This will create an .exe file 
8. Type in "mono 4i2.exe" to run the code. 


## Blackbox test: 

* Len-function:

Four different tests for x and y were ran. 

A coincidence where both values are 0.
A coincidence where both values are positive
A coincidence where both values are negative 
A concidence where only one of the values are positive.

Pythagorean triples were chosen for every coincidence, which made it easy to input and output pretty values. 

The test outcome was as expected as every coincidence turned out true in the test. 

* Add-function: 

Many different coincidences for the tuple-pairs (x2,y2) and (x3,y3) were tested. 
One where all values were 0
One were all values were > 0 
One where all values were < 0 
One where (x2,y2) had a negative value, but the values of (x3,y3) were positive. 
One where one vector was the zero vector.
One where both were vertical vectors.
One where both were vertical vectors, but where the second vector was negative vertical. 
One where both vectors were horizontal. 
One where both vectors were horizontal, but one was negative horizontal. 
One where vectors were ortogonal. 

Quite small values for x and y were chosen to make it easy to compute by hand. The tests suceeded and showed that the function works for these cases.

* Ang-function:

Three different cases for the ang-function were tested. 

One where all values were positive.
One where all values were negative
One where only one value were positive. 

The test initially failed, as the inaccuracy of the floating point numbers had not been taken into account. 
This was fixed by defining a new function "=~", that took the float inaccuracy into account, whereafter the test ran as expected. 


## Tracing-by-hand:

When I performed the tracing by hand procedure, I did not stumple across any errors. 

My calculations matched completely with the runned code in Fsharp. 

It can be seen in the tracing table below that the outputs match with that of the 4i2.fsx. 

Vector v (1.3, -2.5) outputs (2.817801, -1.091277)
Vector w (-0.1, 0.5) outputs (0.509902, 1.768192)
Vector s (1.2, -2.0) which adds vector v and w outputs (2.332381, -1.030377)


+------+-----------+----------+-------+---------------------------------------------------------------------------+
| Step | Lin fsx | Line fs    |   Env | Binding                                                                   |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 0    |           |          | E0    | ()                                                                        |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 1    | 1         |          | E0    | v = (1.3, -2.5)                                                           |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 2    | 2         |          | E0    | printfn "Vector %A: (%f, %f)" v (vec2dSmall.len v) (vec2dSmall.ang v) = ? |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 3    | 2         |          | E0    | Vec2dSmall.len v = ?                                                      |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 4    |           | 3        | E1    | Len v, sqrt(x * x + y * y), ()                                            |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 5    |           | 3        | E1    | return = 2.817801                                                         |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 6    | 2         |          | E1    | Len v = 2.817801                                                          |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 7    | 2         |          | E0    | vec2dSmall.ang v = ?                                                      |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 8    |           | 6        | E2    | Ang v, atan x1 y1, ()                                                     |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 9    |           | 6        | E2    | return = -1.091277                                                        |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 10   |           | 6        | E2    | Ang v = -1.091277                                                         |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 11   | 3         |          | E0    | let w = (-0.1 , 0.5)                                                      |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 12   | 4         |          | E0    | printfn "Vector %A: (%f, %f)" w (vec2dSmall.len w) (vec2dSmall.ang w)     |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 13   | 4         |          | E0    | vec2dSmall.len w = ?                                                      |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 14   |           | 3        | E3    | Len w, sqrt(x * x + y * y), ()                                            |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 16   |           | 3        | E3    | Return = 0.509902                                                         |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 17   |           | 3        | E3    | Len w = 0.509902                                                          |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 18   | 4         |          | E0    | Vec2dSmall.ang w = ?                                                      |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 19   |           | 6        | E4    | Ang w, atan x1 y1, ()                                                     |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 20   |           | 6        | E4    | Return = 1.768192                                                         |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 21   |           | 6        | E6    | Ang w = 1.768192                                                          |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 22   | 3         |          | E0    | s = vec2dSmall.add v w                                                    |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 23   | 3         |          | E0    | vec2dSmall.add v w = ?                                                    |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 24   |           | 9        | E7    | s, (x2 + x3, y2 + y3), v w, ()                                            |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 25   |           | 9        | E7    | Return (1.2, -2.0)                                                        |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 26   |           | 9        | E7    | s = (1.2, -2.0)                                                           |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 27   | 6         |          | E0    | printfn "Vector %A: (%f, %f)" s (vec2dSmall.len s) (vec2dSmall.ang s)     |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 28   | 6         |          | E0    | vec2dSmall.len s = ?                                                      |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 29   |           | 3        | E8    | Len s, sqrt(x * x + y * y), ()                                            |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 30   |           | 3        | E8    | Return 2.332381                                                           |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 31   |           | 3        | E8    | Len s = 2.332381                                                          |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 32   | 3         |          | E0    | vec2dSmall.ang s = ?                                                      |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 33   |           | 6        | E9    | Ang s, atan x1 y1, ()                                                     |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 34   |           | 6        | E9    | Return -1.030377                                                          |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 35   |           | 6        | E9    | Ang s = -1.030377                                                         |
+------+-----------+----------+-------+---------------------------------------------------------------------------+
| 36   |           | 6        | E0    | Return ()                                                                 |
+------+-----------+----------+-------+---------------------------------------------------------------------------+




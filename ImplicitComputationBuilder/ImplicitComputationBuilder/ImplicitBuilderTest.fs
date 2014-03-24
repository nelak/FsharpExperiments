module ImplicitBuilderTest
open OpImplicit
open System
open System.Drawing
open Xunit

[<Fact>]
let ``Verirify implicit conversion to string``() = 
    
    let expected = "Hello World!"
    let actual =
        implicit {
            let! implicitConversion = OpImplicit(String = "Hello World")
            return implicitConversion + "!"
        }

    Assert.Equal<string>(expected, actual)

[<Fact>]
let ``Verirify implicit conversion to int``() = 
    
    let expected = 2
    let actual =
        implicit {
            let! implicitConversion = OpImplicit(Integer = 1)
            return implicitConversion + 1
        }

    Assert.Equal(expected, actual)

[<Fact>]
let ``Verirify implicit conversion to single``() = 
    
    let expected = 2.0f
    let actual =
        implicit {
            let! implicitConversion = OpImplicit(Single = 1.0f)
            return implicitConversion + 1.0f
        }

    Assert.Equal(expected, actual)

[<Fact>]
let ``Verirify implicit conversion to int64``() = 
    
    let expected = 2L
    let actual =
        implicit {
            let! implicitConversion = OpImplicit(Int64 = 1L)
            return implicitConversion + 1L
        }

    Assert.Equal(expected, actual)

[<Fact>]
let ``Verirify implicit conversion to int16``() = 
    
    let expected = 2s
    let actual =
        implicit {
            let! implicitConversion = OpImplicit(Int16 = 1s)
            return implicitConversion + 1s
        }

    Assert.Equal(expected, actual)

[<Fact>]
let ``Verirify implicit conversion to PointF``() = 
    let expected = PointF(1.0f, 1.0f)
    let actual =
        implicit {
            let! implicitConversion = Point(1,1)
            return implicitConversion
        }

    Assert.Equal(expected, actual)
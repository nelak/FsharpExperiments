module ImplicitBuilder

type ImplicitBuilder() = 

    member inline this.Bind((x:'T), rest: 'U -> 'V) : 'V =
        let inline (!>) (x:^a) : ^b = ((^a or ^b) : (static member op_Implicit : ^a -> ^b) x)
        !> x |> rest

    member this.Return(x:'T) = x


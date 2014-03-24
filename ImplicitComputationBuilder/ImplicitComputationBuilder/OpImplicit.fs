module OpImplicit

type OpImplicit() =
    
    member val String = "" with get, set

    member val Integer = 0 with get, set

    member val Single = 0.0f with get, set

    member val Int64 = 0L with get, set

    member val Int16 = 0s with get, set

    static member op_Implicit(value:OpImplicit) = 
        value.String

    static member op_Implicit(value:OpImplicit) = 
        value.Integer

    static member op_Implicit(value:OpImplicit) = 
        value.Single

    static member op_Implicit(value:OpImplicit) = 
        value.Int64

    static member op_Implicit(value:OpImplicit) = 
        value.Int16

    static member op_Implicit(value:string) = 
        OpImplicit(String = value)

    static member op_Implicit(value:int) = 
        OpImplicit(Integer = value)

    static member op_Implicit(value:single) = 
        OpImplicit(Single = value)

    static member op_Implicit(value:int64) = 
        OpImplicit(Int64 = value)

    static member op_Implicit(value:int16) = 
        OpImplicit(Int16 = value)
# LAB 7.1 #
## ข้อ 1 ##
``` puml
@startuml 015
class SByte
{
  + Maxvalue : SByte
  + Minvalue : SByte

  + Parse(...) : SByte 
  + TryParse(...) : SByte
  + CompareTo(...) : SByte
  + Equals(...) : bool
  + GatHashCode() : int
  + GetTypeCode() : TypeCode
  + ToString(...) : string
}
@enduml
```
![image](https://user-images.githubusercontent.com/92082259/168339820-bb2cf5a6-c75d-4339-a3c2-26163d477f2a.png)
## ข้อ 2 ##
``` puml
@startuml 015
class Byte
{
  + Maxvalue : byte
  + Minvalue : byte

  + Parse(...) : byte
  + TryParse(...) : byte
  + CompareTo(...) : byte
  + Equals(...) : bool
  + GatHashCode() : int
  + GetTypeCode() : TypeCode
  + ToString(...) : string
}
@enduml
```
![image](https://user-images.githubusercontent.com/92082259/168340050-4c18512e-aab6-4221-9dcf-3543fcb6f59d.png)
## ข้อ 3 ##
``` puml
@startuml 015
class Int16
{
  + Maxvalue : short
  + Minvalue : short

  + Parse(...) : short 
  + TryParse(...) : short
  + CompareTo(...) : short
  + Equals(...) : bool
  + GatHashCode() : int
  + GetTypeCode() : TypeCode
  + ToString(...) : string
}
@enduml
```
![image](https://user-images.githubusercontent.com/92082259/168340208-ba406f70-e4c9-499a-b539-a3ceb63151d0.png)
## ข้อ 4 ##
``` puml
@startuml 015
class UInt16
{
  + Maxvalue : ushort
  + Minvalue : ushort

  + Parse(...) : ushort 
  + TryParse(...) : ushort
  + CompareTo(...) : ushort
  + Equals(...) : bool
  + GatHashCode() : int
  + GetTypeCode() : TypeCode
  + ToString(...) : string
}
@enduml
```
![image](https://user-images.githubusercontent.com/92082259/168340418-7dc55edd-ee75-4ee5-a623-2c9e87b2f5dc.png)
## ข้อ 5 ##
``` puml
@startuml 015
class Int32
{
  + Maxvalue : int
  + Minvalue : int

  + Parse(...) : int 
  + TryParse(...) : int
  + CompareTo(...) : int
  + Equals(...) : bool
  + GatHashCode() : int
  + GetTypeCode() : TypeCode
  + ToString(...) : string
}
@enduml
```
![image](https://user-images.githubusercontent.com/92082259/168340572-8dc80f2e-3535-4241-bd4a-928c01446725.png)

## ข้อ 6 ##
``` puml
@startuml 015
class UInt32
{
  + Maxvalue : uint
  + Minvalue : uint

  + Parse(...) : uint 
  + TryParse(...) : uint
  + CompareTo(...) : uint
  + Equals(...) : bool
  + GatHashCode() : int
  + GetTypeCode() : TypeCode
  + ToString(...) : string
}
@enduml
```
![image](https://user-images.githubusercontent.com/92082259/168340637-7d0de8bc-0377-4d98-bb03-8018b6f6602c.png)

## ข้อ 7 ##
``` puml
@startuml 015
class Int64
{
  + Maxvalue : long
  + Minvalue : long

  + Parse(...) : long 
  + TryParse(...) : long
  + CompareTo(...) : long
  + Equals(...) : bool
  + GatHashCode() : int
  + GetTypeCode() : TypeCode
  + ToString(...) : string
}
@enduml
```
![image](https://user-images.githubusercontent.com/92082259/168340816-96dff0dc-c882-47de-a3f7-a69e1a70efbe.png)
## ข้อ 8 ##
``` puml
@startuml 015
class UInt64
{
  + Maxvalue : ulong
  + Minvalue : ulong

  + Parse(...) : ulong 
  + TryParse(...) : ulong
  + CompareTo(...) : ulong
  + Equals(...) : bool
  + GatHashCode() : int
  + GetTypeCode() : TypeCode
  + ToString(...) : string
}
@enduml
```
![image](https://user-images.githubusercontent.com/92082259/168341079-858d6c08-5eb8-42c1-89ab-1f864a3dc70d.png)
## ข้อ 9 ##
``` puml
@startuml 015
class Single
{
  + Minvalue : float
  + Epsilon : float
  + Maxvalue : float
  + PositiveInfinity : float
  + NegativeInfinity : float
  + NaN : float

  + IsInfinity() : float
  + IsPositiveInfinity() : float
  + IsNegativeInfinity() : float
  + IsNaN() : float
  + Parse(...) : float 
  + TryParse(...) : float
  + CompareTo(...) : float
  + Equals(...) : bool
  + operator ==() : bool
  + operator !=() : bool
  + operator <() : bool
  + operator >() : bool
  + operator <=() : bool
  + operator >=() : bool
  + GatHashCode() : int
  + GetTypeCode() : TypeCode
  + ToString(...) : string
}
@enduml
```
![image](https://user-images.githubusercontent.com/92082259/168341234-94a2d3ae-c0ed-4016-a79a-564e572a6466.png)
## ข้อ 10 ##
``` puml
@startuml 015
class Double
{
  + Minvalue : double
  + Maxvalue : double
  + Epsilon : double
  + NegativeInfinity : double
  + PositiveInfinity : double
  + NaN : double

  + IsInfinity() : double
  + IsPositiveInfinity() : double
  + IsNegativeInfinity() : double
  + IsNaN() : double
  + Parse(...) : double
  + TryParse(...) : double
  + CompareTo(...) : double
  + Equals(...) : bool
  + operator ==() : bool
  + operator !=() : bool
  + operator <() : bool
  + operator >() : bool
  + operator <=() : bool
  + operator >=() : bool
  + GatHashCode() : int
  + GetTypeCode() : TypeCode
  + ToString(...) : string
}
@enduml
```
![image](https://user-images.githubusercontent.com/92082259/168341337-39ceeb0d-2e61-471b-a9d4-5b086da80f22.png)
## ข้อ 11 ##
``` puml
@startuml 015
class Boolean
{
  + TrueString : string
  + FalseString : string

  + Parse(...) : bool
  + TryParse(...) : bool
  + CompareTo(...) : bool
  + Equals(...) : bool
  + GatHashCode() : int
  + GetTypeCode() : TypeCode
  + ToString(...) : string
  - TrimWhiteSpaceAndNull() : string
}
@enduml
```
![image](https://user-images.githubusercontent.com/92082259/168341448-d8452362-bff5-46b0-baef-c03b08a35583.png)
## ข้อ 12 ##
``` puml
@startuml 015
class Char
{
  + Maxvalue : char
  + Minvalue : char

  + Parse(...) : char 
  + TryParse(...) : char
  + CompareTo(...) : char
  + IsControl(...) : char
  + IsDigit(...) : char
  + IsLetter(...) : char
  + IsLetterOrDigit(...) : char
  + IsNumber(...) : char
  + IsWhiteSpace(...) : char
  + IsSeparator(...) : char
  + IsSurrogate(...) : char
  + IsHighSurrogate(...) : char
  + IsLowSurrogate(...) : char
  + IsSurrogatePair(...) : char
  + IsSymbol(...) : char
  + IsUpper(...) : char
  + IsLower(...) : char
  + IsPunctuation(...) : char
  + ToUpper(...) : char
  + ToUpperInvariant() : char
  + ToLower(...) : char
  + ToLowerInvariant() : char
  + Equals(...) : bool
  + ConvertFromUtf32() : string
  + ConvertToUtf32(...) : int
  + ToString(...) : string
  + GatHashCode() : int
  + GetNumericValue(...) : double
  + GetUnicodeCategory(...) : UnicodeCategory
  + GetTypeCode() : TypeCode
}
@enduml
```
![image](https://user-images.githubusercontent.com/92082259/168341593-4ad7d2ab-d3a1-4bc8-bd03-e98b96e9e986.png)
## ข้อ 13 ##
``` puml
@startuml 015
class Decimal
{
  + Zero : decimal
  + One : decimal
  + MinusOne : decimal
  + Maxvalue : decimal
  + Minvalue : decimal

  + Parse(...) : decimal
  + TryParse(...) : decimal
  # Abs() : decimal
  + Add() : decimal
  - FCallAddSub() : decimal
  - FCallAddSubOverflowed() : decimal
  + Ceiling() : decimal
  + Compare() : decimal
  - FCallCompare() : decimal
  + CompareTo(...) : decimal
  + Divide() : decimal
  - FCallDivide() : decimal
  - FCallDivideOverflowed() : decimal
  + Floor() : decimal
  - FCallFloor() : decimal
  + GetBits() : decimal
  + Remainder() : decimal
  + Multiply() : decimal
  - FCallMultiply() : decimal
  - FCallMultiplyOverflowed() : decimal
  + Negate() : decimal
  + Round(...) : decimal
  - FCallRound() : decimal
  + Subtract() : decimal
  + Truncate() : decimal
  - FCallTruncate() : decimal
  + operator +(...) : decimal
  + operator -(...) : decimal
  + operator ++() : decimal
  + operator --() : decimal
  + operator *() : decimal
  + operator /() : decimal
  + operator %() : decimal
  + operator ==() : bool
  + operator !=() : bool
  + operator <() : bool
  + operator <=() : bool
  + operator >() : bool
  + operator >=() : bool
  + Equals(...) : bool
  + GatHashCode() : int
  + GetTypeCode() : TypeCode
  + ToString(...) : string
  + ToByte() : byte
  + ToSByte() : sbyte
  + ToInt16() : short
  + ToDouble() : double
  + ToInt32() : int
  + ToInt64() : long
  + ToUInt16() : ushort
  + ToUInt32() : uint
  + ToUInt64() : ulong
  + ToSingle() : float
  + ToOACurrency() : long
  + FromOACurrency() : decimal
}
@enduml
```
![image](https://user-images.githubusercontent.com/92082259/168341744-3661f13e-e6fd-4d99-82be-507853a6d93c.png)
## ข้อ 14 ##
``` puml
@startuml 015
class Object
{
  + ToString() : string
  + Equals(...) : bool
  + ReferenceEquals() : bool
  + GatHashCode() : int
  + GetType() : Type
}
@enduml
```
![image](https://user-images.githubusercontent.com/92082259/168341849-e4ebb752-d80c-4e1b-a248-d4505107a5b7.png)
## ข้อ15 ##
``` puml
@startuml 015
class String
{
  + Empty : string

  + Compare(...) : string
  + CompareTo(...) : string
  + CompareOrdinal(...) : string
  + Join(...) : string
  + Split(...) : string
  + Contains() : string
  + EndsWith(...) : string
  + IndexOf(...) : string
  + IndexOfAny(...) : string
  + LastIndexOf(...) : string
  + LastIndexOfAny(...) : string
  + PadLeft(...) : string
  + PadRight(...) : string
  + StartsWith(...) : string
  + ToLower(...) : string
  + ToLowerInvariant(...) : string
  + ToUpper(...) : string
  + ToUpperInvariant(...) : string
  + Clone() : object
  + Insert() : string
  + Replace(...) : string
  + Remove(...) : string
  + Format(...) : string
  + Copy() : string
  + Concat(...) : string
  + Intern() : string
  + IsInterned() : string
  + IsNullOrEmpty() : string
  + IsNullOrWhiteSpace() : string
  + IsNormalized(...) :  bool
  + Normalize(...) : string
  + Substring(...) : string
  + Trim(...) : string
  + TrimStart() : string
  + TrimEnd() : string
  + operator ==() : bool
  + operator !=() : bool
  + Equals(...) : bool
  + CopyTo() : void
  + GatHashCode() : int
  + GetTypeCode() : TypeCode
  + GetEnumerator() : CharEnumerator
  + ToString(...) : string
  + ToCharArray(...) : char
}
@enduml
```
![image](https://user-images.githubusercontent.com/92082259/168342000-ef9f3700-faa2-4294-b20a-111e1b198aed.png)
## LAB 7.2 ##
# debug #
![image](https://user-images.githubusercontent.com/92082259/168342599-652253e2-3121-4272-b686-59e586793166.png)

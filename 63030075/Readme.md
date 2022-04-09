# Week7.1 #

## ข้อ1 ##

``` puml
@startuml
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
![image](https://user-images.githubusercontent.com/92082233/162580786-11b8fa34-e120-4082-bd3d-93bb976fa4e0.png)

## ข้อ2 ##

``` puml
@startuml
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
![image](https://user-images.githubusercontent.com/92082233/162580827-3d61005e-6029-4a85-b0c4-9205f9c46489.png)

## ข้อ3 ##

``` puml
@startuml
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
![image](https://user-images.githubusercontent.com/92082233/162580894-3e47a959-c707-41a1-aed0-f243c783b377.png)

## ข้อ4 ##

``` puml
@startuml
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
![image](https://user-images.githubusercontent.com/92082233/162580927-0cacca60-b618-475a-aade-4a5be3335a27.png)

## ข้อ5 ##

``` puml
@startuml
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
![image](https://user-images.githubusercontent.com/92082233/162580967-9cbcb0d1-f9b4-4bc1-b419-a4df5ad4b717.png)

## ข้อ6 ##

``` puml
@startuml
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
![image](https://user-images.githubusercontent.com/92082233/162581012-f8e4d2bd-f68b-4f28-b746-406cb35c3296.png)

## ข้อ7 ##

``` puml
@startuml
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
![image](https://user-images.githubusercontent.com/92082233/162581045-466e107b-4f02-4932-bb5c-299cd7ad9395.png)

## ข้อ8 ##

``` puml
@startuml
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
![image](https://user-images.githubusercontent.com/92082233/162581082-db02c115-722a-4054-8c4e-7605c3afa5e4.png)

## ข้อ9 ##

``` puml
@startuml
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
![image](https://user-images.githubusercontent.com/92082233/162581120-ad8d6a58-32a4-4727-a81b-620aa90ffb92.png)

## ข้อ10 ##

``` puml
@startuml
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
![image](https://user-images.githubusercontent.com/92082233/162581176-7759bc45-f667-4d13-bac9-99ed35d2421e.png)

## ข้อ11 ##

``` puml
@startuml
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
![image](https://user-images.githubusercontent.com/92082233/162581218-096914eb-9ee0-4064-8d0f-e2179b0d7802.png)

## ข้อ12 ##

``` puml
@startuml
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
![image](https://user-images.githubusercontent.com/92082233/162581313-66561e6b-7c1c-42a9-85da-56270c2b26b4.png)
## ข้อ 13 ##

``` puml
@startuml
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

![image](https://user-images.githubusercontent.com/92082233/162581425-3eb05cf5-cead-4d7a-80c6-02e62c886c08.png)

## ข้อ14 ##

``` puml
@startuml
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
![image](https://user-images.githubusercontent.com/92082233/162581397-b983a59a-ea96-4f1a-b6f0-238987c47933.png)

## ข้อ15 ##


``` puml
@startuml
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

![image](https://user-images.githubusercontent.com/92082233/162581360-c9aa92f2-26be-4b80-901f-89633a7e857f.png)

# Week7.2 #
![image](https://user-images.githubusercontent.com/92082233/162581495-3c6e424e-5376-430b-9840-ea6d1bde5fee.png)

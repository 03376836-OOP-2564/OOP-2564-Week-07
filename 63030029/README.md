# การทดลองสัปดาห์ที่ 7.1 #
เขียนโค้ด PlantUML สำหรับ type ชนิดอื่น ๆ โดยใช้วิธีเดียวกันกับขั้นตอนที่ 3 ในชนิดข้อมูล SByte เพื่อสร้าง diagram สำหรับ predefined type ทุกชนิด

## ข้อ 1 sbyte ##

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
![image](https://user-images.githubusercontent.com/92082240/169649117-494c4ee6-624a-42b3-b34c-71b3800f5c75.png)

## ข้อ 2 byte ##

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

![image](https://user-images.githubusercontent.com/92082240/169649131-2ee1b8a0-be0a-4750-90cd-5038d2ab68cc.png)

## ข้อ 3 short ##

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

![image](https://user-images.githubusercontent.com/92082240/169649137-f4df1143-0930-4196-9847-b3a5b4401620.png)

## ข้อ 4 ushort ##

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

![image](https://user-images.githubusercontent.com/92082240/169649147-b66fb83d-d001-46ab-a149-8ebb1ec61698.png)


## ข้อ 5 int ##

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

![image](https://user-images.githubusercontent.com/92082240/169649157-a8eff634-292a-4e95-bce4-26def6e108f9.png)

## ข้อ 6 uint ##

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

![image](https://user-images.githubusercontent.com/92082240/169649178-5045bf74-2af9-4015-bc1e-4ee206bbcac3.png)

## ข้อ 7 long ##

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

![image](https://user-images.githubusercontent.com/92082240/169649194-3ee2d35d-0f66-4252-abce-7b8fea57d701.png)

## ข้อ 8 ulong ##

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

![image](https://user-images.githubusercontent.com/92082240/169649203-d106aa41-1b39-49b8-8742-7d6f19095873.png)

## ข้อ 9 float ##

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

![image](https://user-images.githubusercontent.com/92082240/169649222-5954806a-3a94-444a-9d1c-3f636f7ecf21.png)

## ข้อ 10 double ##

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

![image](https://user-images.githubusercontent.com/92082240/169649236-24fe61c0-4462-49b7-b08b-15bc54e3c3cc.png)

## ข้อ 11 bool ##

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

![image](https://user-images.githubusercontent.com/92082240/169649260-54545cbc-e54e-408e-9f33-c568a35c41a0.png)

## ข้อ 12 char ##

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

![image](https://user-images.githubusercontent.com/92082240/169649266-552fdb4c-39c6-4ff8-9324-ec18f992f1e1.png)

## ข้อ 13 decimal ##

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

![image](https://user-images.githubusercontent.com/92082240/169649278-d07ae78d-3840-4faf-9f40-4af74bb6b168.png)

## ข้อ 14 object ##

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

![image](https://user-images.githubusercontent.com/92082240/169649298-4fae58ab-99d9-4e57-b8af-f2c55177e9d1.png)

## ข้อ 15 string ##

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

![image](https://user-images.githubusercontent.com/92082240/169649313-a4efaa42-47d2-46d5-9c75-7bedbeab3cbd.png)

# การทดลองสัปดาห์ที่ 7.2 #
แสดงรายละเอียดของ predefined type
![Screenshot 2022-05-21 174317](https://user-images.githubusercontent.com/92082240/169649343-063a7a1f-854b-4c13-9423-46ec1f3927af.png)

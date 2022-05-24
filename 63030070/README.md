# การทดลองสัปดาห์ที่ 7.1 #
เขียนโค้ด PlantUML สำหรับ type ชนิดอื่น ๆ โดยใช้วิธีเดียวกันกับขั้นตอนที่ 3 ในชนิดข้อมูล SByte เพื่อสร้าง diagram สำหรับ predefined type ทุกชนิด

## 1.sbyte ##

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

![image](https://user-images.githubusercontent.com/92082479/169657589-2e9d85d6-1963-4e68-b8bf-12c0d2cfa9ed.png)
## 2.byte ##

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

![image](https://user-images.githubusercontent.com/92082479/169658160-17b10e60-0c62-455b-ba55-3f40d72fa99f.png)

## 3.short ##

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

![image](https://user-images.githubusercontent.com/92082479/169658248-1b7e8a05-b1dc-42f7-8b45-077670a04feb.png)

## 4.ushort ##

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

![image](https://user-images.githubusercontent.com/92082479/169658383-e359ddc0-bc28-4de8-bef1-8f3b70f80aea.png)
## 5.int ##

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

![image](https://user-images.githubusercontent.com/92082479/169658423-2b250154-f87e-42db-aa32-d2dca6233a43.png)

## 6.uint ##

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

![image](https://user-images.githubusercontent.com/92082479/169658458-32c695c1-d661-4c52-9cc4-808a8bb0337f.png)

## 7.long ##

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

![image](https://user-images.githubusercontent.com/92082479/169658496-c8ecec62-516e-478d-8c87-e461f5097298.png)

## 8.ulong ##

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

![image](https://user-images.githubusercontent.com/92082479/169658518-ed580ae6-9cc0-4d95-adea-00f7fdcfcff6.png)

## 9.float ##

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

![image](https://user-images.githubusercontent.com/92082479/169658547-e113e665-4fd6-4d2c-a912-bc8169aef41e.png)

## 10.double ##

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

![image](https://user-images.githubusercontent.com/92082479/169658571-c60ea26b-7fb6-43d4-98f8-606e57a0c381.png)

## 11.bool ##

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

![image](https://user-images.githubusercontent.com/92082479/169658616-7e43f2e0-0eda-4e6e-823a-d936513ebb85.png)

## 12.char ##

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

![image](https://user-images.githubusercontent.com/92082479/169658649-4b54be3f-9a89-44cb-bce9-0ad2884da9c8.png)
## 13.decimal ##

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

![image](https://user-images.githubusercontent.com/92082479/169658689-3da1f455-84cb-4d6c-9e1e-da82f1ad9110.png)

## 14.object ##

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

![image](https://user-images.githubusercontent.com/92082479/169658711-28fc5fc0-81f0-4465-a3b9-388ef4064b47.png)
## 15.string ##

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
# การทดลองสัปดาห์ที่ 7.2 #
แสดงรายละเอียดของ predefined type

![image](https://user-images.githubusercontent.com/92082479/169658995-9e43ec69-3af6-491c-8eb7-2b22f848a359.png)

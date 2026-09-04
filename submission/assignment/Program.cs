// .csproj: يحتوي على إعدادات المشروع مثل Target Framework و OutputType و Nullable و ImplicitUsings.
// Program.cs: يحتوي على الكود الرئيسي للبرنامج.
// obj/: يحتوي على ملفات مؤقتة يتم إنشاؤها أثناء عملية Build.
// bin/: يحتوي على الملفات الناتجة من عملية Build.

// File-scoped namespace:
// نكتب الـ namespace في سطر واحد بدون { }، لذلك لا نحتاج إلى مستوى إضافي من الـ indentation.

// This project uses the newer .slnx format.
// One advantage of the classic .sln format is broader compatibility with older Visual Studio versions and tools.

using CSharpBasicsAssignment;
using System.Diagnostics.Metrics;

Console.WriteLine("=== PART A: Project & Structure ===");
Console.WriteLine("Project structure is ready.");

RunTypesDemo();
RunValueVsReferenceDemo();

Console.WriteLine("=== PART D: Scope & Operators ===");

ScopeDemo.FirstMethod();
ScopeDemo.SecondMethod();
ScopeDemo.MethodScopeDemo();
ScopeDemo.BlockScopeDemo();
       
Console.WriteLine("=== PART D2: Compound Assignment Operators ===");

int total = 100;

total += 5;
Console.WriteLine($"After += 5: {total}");

total -= 10;
Console.WriteLine($"After -= 10: {total}");

total *= 2;
Console.WriteLine($"After *= 2: {total}");

total /= 5;
Console.WriteLine($"After /= 5: {total}");

total %= 7;
Console.WriteLine($"After %= 7: {total}");

// total += 5; is equivalent to: total = total + 5;


Console.WriteLine("=== PART D3: Bitwise Operators ===");

int a = 12;
int b = 10;

// 12 = 1100
// 10 = 1010
//
// AND (&):  1100
//           1010
//           ----
//           1000 = 8
//
// OR (|):   1100
//           1010
//           ----
//           1110 = 14
//
// XOR (^):  1100
//           1010
//           ----
//           0110 = 6

Console.WriteLine($"a & b = {a & b}");
Console.WriteLine($"a | b = {a | b}");
Console.WriteLine($"a ^ b = {a ^ b}");

// & is bitwise and works bit-by-bit.
// && is logical AND and is used with conditions; if the left operand is false,
// the right condition is not evaluated because of short-circuiting.

Console.WriteLine("=== PART F: LeetCode 136 - Single Number ===");

int[] numbers1 = { 4, 1, 2, 1, 2 };
int[] numbers2 = { 2, 2, 1 };

Console.WriteLine($"Single number in first array: {FindSingleNumber(numbers1)}");
Console.WriteLine($"Single number in second array: {FindSingleNumber(numbers2)}");


void RunTypesDemo()
{
    Console.WriteLine("=== PART B: Variables, Types & Casting ===");

    int age = 20;
    long population = 1000000;
    double temperature = 36.5;
    decimal salary = 15000.75m;
    bool isStudent = true;
    char grade = 'A';
    string name = "Ali";
    var score = 95;

    Console.WriteLine($"int: {age} - {age.GetType()}");
    Console.WriteLine($"long: {population} - {population.GetType()}");
    Console.WriteLine($"double: {temperature} - {temperature.GetType()}");
    Console.WriteLine($"decimal: {salary} - {salary.GetType()}");
    Console.WriteLine($"bool: {isStudent} - {isStudent.GetType()}");
    Console.WriteLine($"char: {grade} - {grade.GetType()}");
    Console.WriteLine($"string: {name} - {name.GetType()}");
    Console.WriteLine($"var: {score} - {score.GetType()}");


    // Implicit conversion: no cast is required because these conversions are safe.
    int number = 100;
    long bigNumber = number;

    char letter = '1';
    int asciiValue = letter;

    Console.WriteLine($"int to long: {bigNumber}");
    Console.WriteLine($"char to int: {asciiValue}");


    // Explicit cast truncates the decimal part, while Convert.ToInt32 rounds the value.
    double value = 9.8;

    int castResult = (int)value;
    int convertResult = Convert.ToInt32(value);

    Console.WriteLine($"Explicit cast: {castResult}");
    Console.WriteLine($"Convert.ToInt32: {convertResult}");


    // Integer division removes the decimal part because both operands are integers.
    int intDivision = 5 / 2;
    double doubleDivision = 5.0 / 2;

    Console.WriteLine($"5 / 2 as int: {intDivision}");
    Console.WriteLine($"5.0 / 2 as double: {doubleDivision}");


    // Boxing: the int value is stored inside an object.
    int originalNumber = 42;
    object boxedNumber = originalNumber;

    Console.WriteLine($"After boxing: {boxedNumber}");

    // Unboxing: the value is extracted from the object and converted back to int.
    int unboxedNumber = (int)boxedNumber;

    Console.WriteLine($"After unboxing: {unboxedNumber}");


    // Parsing a valid string.
    string text = "42";
    int parsedNumber = int.Parse(text);

    Console.WriteLine($"Parsed number: {parsedNumber}");

    // TryParse safely handles invalid input without throwing an exception.
    string badText = "abc";
    bool success = int.TryParse(badText, out int result);

    Console.WriteLine($"TryParse succeeded: {success}");

    if (!success)
    {
        Console.WriteLine("Parsing failed because the input is not a valid integer.");
    }


    // float to decimal requires an explicit cast because the conversion may lose precision.
    float floatNumber = 10.5f;

    // This does not compile because float to decimal is not an implicit conversion.
    // decimal decimalNumber = floatNumber;

    decimal decimalNumber = (decimal)floatNumber;

    Console.WriteLine($"float to decimal: {decimalNumber}");
}


void RunValueVsReferenceDemo()
{
    Console.WriteLine("=== PART C: Value vs. Reference Types ===");

    // Experiment 1: Struct copy semantics.

    Point p1 = new Point { X = 1, Y = 2 };
    Point p2 = p1;

    // Structs are value types, so assigning p1 to p2 copies the value.
    // Changing p2 does not change p1.

    p2.X = 99;

    Console.WriteLine($"p1.X = {p1.X}");
    Console.WriteLine($"p2.X = {p2.X}");


    // Experiment 2: Class reference semantics.

    Order o1 = new Order
    {
        OrderId = 1,
        CustomerName = "Ali",
        Quantity = 2,
        UnitPrice = 100m,
        TotalPrice = 0m,
        IsPaid = false,
        DiscountPercent = 10,
        ShippingCity = "Minya",
        Priority = 'H',
        ItemCode = 123456
    };

    o1.CalculateTotal();

    Console.WriteLine($"Order total: {o1.TotalPrice}");

    Order o2 = o1;

    // Order is a reference type, so o1 and o2 refer to the same object on the heap.
    // Changing the object through o2 is visible through o1.

    o2.IsPaid = true;

    Console.WriteLine($"o1.IsPaid = {o1.IsPaid}");
    Console.WriteLine($"o2.IsPaid = {o2.IsPaid}");


    // Order is a reference type, so assigning it to an object variable does not create a new object.

    object boxedOrder = o1;

    Order o3 = (Order)boxedOrder;

    Console.WriteLine($"Same instance: {object.ReferenceEquals(o1, o3)}");


    // o2.PrintSummary() reflects the change because o1 and o2 reference the same Order object.

    o2.PrintSummary();


    // Stack vs. Heap explanation:
    // Value types such as Point store their actual values, while reference-type variables store a reference to an object.
    // Assigning a value type copies the actual value, so p1 and p2 become independent copies.
    // Assigning a reference type copies the reference, so o1 and o2 point to the same object on the heap.
    // Storing a reference type in an object variable does not create a new object; it stores the same reference.
}

int FindSingleNumber(int[] nums)
{
    int result = 0;

    foreach (int num in nums)
    {
        result ^= num;
    }

    // XOR of two equal numbers is 0, and XOR with 0 returns the original number.
    // Therefore, all pairs cancel out and only the number appearing once remains.

    return result;
}


class ScopeDemo
{
    // Field scope: this field can be accessed by multiple methods in this class.
    private static int fieldValue = 100;


    public static void FirstMethod()
    {
        Console.WriteLine($"Field from FirstMethod: {fieldValue}");
    }


    public static void SecondMethod()
    {
        Console.WriteLine($"Field from SecondMethod: {fieldValue}");
    }


    public static void MethodScopeDemo()
    {
        // This local variable exists only inside this method.
        int localValue = 50;

        Console.WriteLine($"Local variable inside method: {localValue}");
    }


    public static void BlockScopeDemo()
    {
        for (int i = 0; i < 3; i++)
        {
            int insideLoop = i * 10;

            Console.WriteLine($"Inside loop: {insideLoop}");
        }

        // Console.WriteLine(i);
        // Console.WriteLine(insideLoop);
        // Both variables are out of scope here, so using them would cause a compile error.
    }

}
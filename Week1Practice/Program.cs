



class Program
{
  static void Main()
  {
    // ** Lesson 1: Input/Output & First Program
    // Concept: Every algorithm starts with reading input and producing output.
    // Best practice: Always validate input in contests or interviews.
    // Console.WriteLine("Enter your name:");
    // string name = Console.ReadLine();
    // Console.WriteLine($"Hello {name}");

    // ** Lesson 2: Variables, Data Types & Operators
    // Built-in Value Types: Any value type can be made nullable with ?
    //   Integer: sbyte, byte, short, ushort, int, uint, long, ulong, char
    //   Floating: float, double, decimal
    //   Other: bool, enum, struct, DateTime
    // Built-in Reference Types:
    //   string, object, dynamic, array, collections, User-defined (class, interface, etc.)

    // 1. Arithmetic Operators
    // int a = 10, b = 3;
    // Console.WriteLine(a + b);
    // Console.WriteLine(a - b);
    // Console.WriteLine(a * b);
    // Console.WriteLine(a / b);
    // Console.WriteLine(a % b);

    // 2. Comparison Operators
    // int a = 5, b = 10;
    // Console.WriteLine(a == b);
    // Console.WriteLine(a != b);
    // Console.WriteLine(a > b);
    // Console.WriteLine(a < b);
    // Console.WriteLine(a >= 5);
    // Console.WriteLine(a <= 5);

    // 3. Logical Operators
    // bool x = true, y = false;
    // Console.WriteLine(x && y);
    // Console.WriteLine(x || y);
    // Console.WriteLine(!y);

    // 4. Assignment & Shorthand Operators
    // int num = 10;
    // num += 5;
    // num -= 2;
    // num *= 5;
    // num /= 5;
    // num %= 5;
    // Console.WriteLine(num);

    // ** Lesson 3: Control Flow: If/else for decisions, Loops: for, while, do while, foreach
    // Console.WriteLine("Enter your age:");
    // int userAge = int.Parse(Console.ReadLine());
    // if (userAge >= 18)
    // {
    //   Console.WriteLine("You're an Adult");
    // }
    // else if (userAge < 18 && userAge > 0)
    // {
    //   Console.WriteLine("You are not Adult");
    // }
    // else
    // {
    //   Console.WriteLine("Negitive number not allowed!");
    // }

    // for (int i = 1; i <= 100; i++)
    // {
    //   Console.WriteLine(i);
    // }

    // int n = 10;
    // while (n > 0)
    // {
    //   Console.WriteLine($"Number is now: {n}");
    //   n--;
    // }

    // int n = 100;
    // do
    // {
    //   Console.WriteLine($"Number is now: {n}");
    //   n--;
    // } while (n > 0);

    // string[] names = ["Rumman", "Hasan", "Jahid"];
    // foreach (string name in names)
    // {
    //   Console.WriteLine(name);
    // }

    // for (int i = 1; i <= 5; i++)
    // {
    //   Console.WriteLine(i * i);
    // }

    // ** Lesson 4: Functions & Problem Decomposition
    // Reasoning: Breaking problems into smaller reusable functions is key for large problems.
    // static int Sum(int a, int b) => a + b;
    // Console.WriteLine(Sum(10, 20));

    // ** Lesson 5: Intro to Complexity Analysis
    // Time Complexity: How runtime grows with input size n.
    // Space Complexity: How memory usage grows with n.
    // We don’t measure in seconds or MBs. Instead, we use Big-O notation: a way to describe how performance scales.

  }
}
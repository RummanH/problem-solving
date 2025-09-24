using System.Diagnostics;

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

    // int n = 1000;
    // int[] arr = new int[n];
    // for (int i = 0; i < n; i++)
    //   arr[i] = i;

    // Stopwatch sw = new();
    // Process proc = Process.GetCurrentProcess();
    // long GetMemory() => proc.PrivateMemorySize64 / 1024;

    // Console.WriteLine($"Initial Memory: {GetMemory()} KB\n");

    // O(1) - Constant Time
    // long memoryBefore = GetMemory();
    // sw.Start();
    // int x = arr[0];
    // sw.Stop();
    // long memoryAfter = GetMemory();
    // Console.WriteLine($"O(1) - Constant: {sw.ElapsedTicks} ticks, Memory: {memoryAfter - memoryBefore} KB");

    // O(n) - Linear Time
    // long memoryBefore = GetMemory();
    // sw.Start();
    // long sum = 0;
    // for (int i = 0; i < arr.Length; i++)
    //   sum += arr[i];
    // sw.Stop();
    // long memoryAfter = GetMemory();
    // Console.WriteLine($"O(n) - Linear: {sw.ElapsedTicks} ticks, Memory: {memoryAfter - memoryBefore} KB");

    // O(n²) - Quadratic Time
    // long memoryBefore = GetMemory();
    // sw.Start();
    // int count = 0;
    // for (int i = 0; i < arr.Length; i++)
    //   for (int j = 0; j < arr.Length; j++)
    //     count++;
    // sw.Stop();
    // long memoryAfter = GetMemory();
    // Console.WriteLine($"O(n²) - Quadratic: {sw.ElapsedTicks} ticks, Memory: {memoryAfter - memoryBefore} KB");

    // O(log n) - Logarithmic (Binary Search)
    // long memoryBefore = GetMemory();
    // sw.Start();
    // int left = 0, right = n - 1, target = n - 1;
    // while (left <= right)
    // {
    //   int mid = (left + right) / 2;
    //   if (arr[mid] == target) break;
    //   if (arr[mid] < target) left = mid + 1;
    //   else right = mid - 1;
    // }
    // sw.Stop();
    // long memoryAfter = GetMemory();
    // Console.WriteLine($"O(log n) - Logarithmic: {sw.ElapsedTicks} ticks, Memory: {memoryAfter - memoryBefore} KB");

    // O(n log n) - Sorting
    // Random rnd = new();
    // int[] arr2 = new int[n];
    // for (int i = 0; i < n; i++) arr2[i] = rnd.Next(n);
    // long memoryBefore = GetMemory();
    // sw.Start();
    // Array.Sort(arr2);
    // sw.Stop();
    // long memoryAfter = GetMemory();
    // Console.WriteLine($"O(n log n) - Sorting: {sw.ElapsedTicks} ticks, Memory: {memoryAfter - memoryBefore} KB");

    // O(2^n) - Exponential (Recursive Fibonacci)
    // int fibN = 100;
    // long memoryBefore = GetMemory();
    // sw.Start();
    // int Fib(int k)
    // {
    //   if (k <= 1) return k;
    //   return Fib(k - 1) + Fib(k - 2);
    // }
    // int result = Fib(fibN);
    // sw.Stop();
    // long memoryAfter = GetMemory();
    // Console.WriteLine($"O(2^n) - Fibonacci({fibN}): {sw.ElapsedTicks} ticks, Memory: {memoryAfter - memoryBefore} KB");

    // ** Exercise: Week 1 Review
    // Sum of Two Numbers
    // Console.WriteLine("Enter two numbers:");
    // string[] parts = Console.ReadLine()!.Split();
    // int a = int.Parse(parts[0]);
    // int b = int.Parse(parts[1]);
    // Console.WriteLine(a + b);

    // Even or Odd
    // Console.WriteLine("Enter a number:");
    // int n = int.Parse(Console.ReadLine()!);
    // Console.WriteLine(n % 2 == 0 ? "Number is Even" : "Number is Odd");

    // Print First N Fibonacci Numbers
    // The Fibonacci sequence is a famous series of numbers where each number is the sum of the two before it.
    // Console.WriteLine("Enter a number:");
    // int n = int.Parse(Console.ReadLine()!);
    // int a = 0, b = 1;
    // for (int i = 0; i < n; i++)
    // {
    //   Console.WriteLine(a + " ");
    //   int temp = a + b;
    //   a = b;
    //   b = temp;
    // }

    // Reverse a String
    // Console.WriteLine("Enter a string:");
    // string s = Console.ReadLine()!;
    // char[] arr = s.ToCharArray();
    // Array.Reverse(arr);
    // Console.WriteLine(new string(arr));

    // Find Maximum of Three Numbers
    // Console.WriteLine("Enter numbers:");
    // int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    // Console.WriteLine(numbers.Max());

    // ** Interview Questions & Answers
    // 1. What is Big-O notation?
    // A way to describe how an algorithm's time or space requirements grow as input size increases.

    // 2. Why is input validation important?
    // To ensure the program handles unexpected or invalid input gracefully.

    // 3. What is the difference between int and long?
    // int is a 32-bit signed integer, while long is a 64-bit signed integer.

    // 4. When do you use loops vs recursion?
    // Use loops for iterative processes and when performance is critical. Use recursion for problems that can be divided into smaller subproblems.

    // 5. How to break down a problem?
    // Understand input/output, Identify constraints, Break into subproblems, Solve each subproblem, Combine solutions.

    // ** Think Like a Top Problem-Solver
    // Always analyze the problem before coding.
    // Write pseudocode to avoid messy logic.
    // Ask: What’s the worst-case input size?
    // Plan test cases: edge cases (0, 1, negative, large inputs)
    // Think in terms of patterns (looping, conditionals, decomposition)
  }
}
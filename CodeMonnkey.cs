using System;
class Program {
  static void Main(string[] args) {

// Functions

    Console.WriteLine("Hello New World");
    SayHello("CodeMonkey", 67);
    int numbers = addNumbers;
    Console.WriteLine(numbers);

    Console.WriteLine(isPositive(5) + "; " + isPositive(-2));

    static void SayHello(string playerName, int age) {
        Console.WriteLine($"Hello {playerName}, you are {age} years old.");
    }

    static int addNumbers(int x, int y) {
        return x + y;
    }

    static bool isPositive(int x) {
      return x >= 0;
    }

    // ---------------------------------------------------------------------------------------------------------------------------------
    // ---------------------------------------------------------------------------------------------------------------------------------
    // Scopes -- When defining a variable, you are defining a local variable. It will only exist in the code block it is located within.

    static void Main(string[] args) { // Code Block One
        int age2 = 35
        bool isPlayer = false
        SayHello2("CodeMonkey", age2);
    }

    static void SayHello2(string playerName, int age2) { // Code Block Two
        isPlayer = true;
        Console.WriteLine($"Hello {playerName}, you are {age2} years old.");
    }
   
    // When typing in Line 36, "isPlayer" does not automatically show up because it only called in a previous block of code.
    // You also can not call variable before it is declared.
    // If a local variable is in a code block of a code block, it can be called as it is still within the original code block.
    // You can define a variable underthe class code block since the code blocks are associated with the class code block. 
    // You can not call a variable in a completely different code block

    // ---------------------------------------------------------------------------------------------------------------------------------
    // ---------------------------------------------------------------------------------------------------------------------------------

    // Comments -- Two forward slashes (" // ") or " /* " at the beginning of the comment(s) and " */ " at the end of the comment(s).
    // The program will ignore any code/messages you comment out.
    // Comments can help other programs who are not working on the code know what everything is doing and why. 
    

   









    

  





  } // NEVER CHANGE THIS LINE
} // NEVER CHANGE THIS LINE
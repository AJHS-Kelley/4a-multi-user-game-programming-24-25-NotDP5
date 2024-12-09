using System;
class Program {
  static void Main(string[] args) {

    // Functions

    Console.WriteLine("Hello New World");
    SayHello("David", 17);
    int numbers = addNumbers(1,2);
    Console.WriteLine(numbers);

    static void SayHello(string playerName, int age) {
      Console.WriteLine($"Hello {playerName} you are {age} years old.");
    }

    static int addNumbers(int x, int y) {
      return x + y;
    }

    bool isPositive(int x) {
      if (x >= 0) {
        return true;
      } else {
        return false;
      }
    }









    

  





  } // NEVER CHANGE THIS LINE
} // NEVER CHANGE THIS LINE
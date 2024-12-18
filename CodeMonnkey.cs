using System;
class Program {}
  static void Main(string[] args) {

    // First Video

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

    // ---------------------------------------------------------------------------------------------------------------------------------
    // ---------------------------------------------------------------------------------------------------------------------------------

    // Loops -- You have 4 types of loops: while, do while, for, and foreach.
    // Can help you run certain logics at one time.

    // While loops -- A simple loop that will run the condition thats with the {} as long as that condition is true. 
    static void Main(string[] args) {
      while (true) {
        Console.WriteLine("Do Something")
      }
    } // This code will print forever since the condition will stay true. 

      static void Main(string[] args) {
      int i = 0;
      while (i < 3) {
        Console.WriteLine("Do Something")
      }
    } // This code will print until it reaches the number 2 since 3 is not less than 3. 

    // ---------------------------------------------------------------------------------------------------------------------------------
    // Do loops -- Runs the condition that is stated and will check afterwards compared to the while loop checking before the condition runs.  

    do {
      Console.WriteLine("Do while loop " + i);
      i++;
    } while (i < 3); 

    // ---------------------------------------------------------------------------------------------------------------------------------
    // For loops -- Broken up into 3 parts: the initialzer, the condition, and the incrementer. 
    // Makes it easier to handle the in 

    for (int i = 0; i < 3; i++) { // It will check in chronological order. Starting with the initialzer, then the condition, and then the incrementer. 
      Console.WriteLine("For Loop " + i);
    }

    // For loops can be used to cycle through an array.

    string[] nameArray = new string[] {
      "David"
      "Todd"
      "Mike"
      "Ronald"
    };
    
    for (int i = 0; i < nameArray.Length; i++) {  // This will bring out the entire list of nameArray. 
      Console.WriteLine(nameArray[i]);
    }

    // ---------------------------------------------------------------------------------------------------------------------------------
    // foreach loops -- Uses an iterator instead of an index to the collection element.
    foreach (string name in nameArray) {
      Console.WriteLine(name);
    }

    // ---------------------------------------------------------------------------------------------------------------------------------
    // ---------------------------------------------------------------------------------------------------------------------------------

    // Classes -- One of the core coding concepts that is basically a type 
    // Can make a type and can create instances or object that go with that type. 

    static void Main(string[] args) {
      int age = 54;
      Player David = new Player();
      Player Preston = new Player();
      Console.WriteLine(player);
    }

    class Player {
      public Player() {
        console.WriteLine("Creating player.");
      }
    }
    
    // Do Naming Rules in video one

    // ---------------------------------------------------------------------------------------------------------------------------------
    // ---------------------------------------------------------------------------------------------------------------------------------
    // ---------------------------------------------------------------------------------------------------------------------------------
    // ---------------------------------------------------------------------------------------------------------------------------------

    // Second Video

    // Refactoring -- The act of rewriting or reorganizing code. It is a constant never-ending process. 
    
    // ---------------------------------------------------------------------------------------------------------------------------------

    // Enums -- Helps define unique values with clear and understandable names

    // Before adding enums

    // private void HandleSate() {
      // switch (state) {
        // case State.MovingToEnemey:
            // Moving to Enemy logic
            // break;
        // case State.LookingForEnemy:
            // break;
        // case State.AttackingEnemy:
            // break;
      // }
    // }

    // After adding enums 
    
    private enum playerAction {
      NoEnemy,
      NoPathToEnemy,
      MovingTowardsEnemey,
      AttackingEnemy
    }

    private enum State {
      LookingForEnemy,
      MovingToEnemey,
      AttackingEnemy,
    }

    private State state;

    private void Start() {
      PlayerAction playerAction = playerAction.NoEnemy;
      Debug.Log(playerAction); // Displays in console log that there are no enemies currently around the player
    }

    private void HandleSate() {
      switch (state) {
        case State.MovingToEnemey:
            // Moving to Enemy logic
            break;
        case State.LookingForEnemy:
            break;
        case State.AttackingEnemy:
            break;
      }
    }

    private PlayerAction GetNextPlayerAction() {
      if (!PlayerHasEnemy()) {
        return PlayerAction.NoEnemy;
      }
      if (!HasPathToEnemy()) {
        return PlayerAction.NoPathToEnemy;
      }
      if (!MovingTowardsEnemey()) {
        return PlayerAction.MovingTowardsEnemey;
      }
      else {
        return PlayerAction.AttackingEnemy;
      }
    }

    // ---------------------------------------------------------------------------------------------------------------------------------
    // Properties -- Mix of a function of a variable

    private static string playerName6;

    // private static string PlayerName5 { get; set; } // Not truly a function. It does not store any data directly, but an "auto implemented property"
    
    private static string PlayerName5 { // Work the same way as the code above. 
      get {
        return PlayerName5;
      }
      set {
        playerName6 = value
      }
    }
    PlayerName5 = "David Ponder";
    Console.WriteLine(PlayerName5); // Prints out the associated name 

    // ---------------------------------------------------------------------------------------------------------------------------------
    // Multi-Dimensional Arrays -- Stores collections of data in more than one dimension

    namespace CodeMonkey_CSharpCourse {
      public class Program {
        private static void(string[] args) {
          int[,] int Array = new int { { 1, 2, 3 }, { 4, 5, 6} };

          for (int i=0; i < intArray.GetLength(0); i++) {
            for (int i=0; i < intArray.GetLength(0); i++) {
              Console.WriteLine(i + ", " + j + ": " + intArray[i, j]);
          }
        }
      }
    }









  } // NEVER CHANGE THIS LINE
} // NEVER CHANGE THIS LINE
// Data Types and Operators, David Ponder, v0.0
using System;
class DataTypeOperators { 
  static void Main() {
    // This comment is here so it wont get fined

    /* This comment is also here so it wont get fined
    */

    // Data Types
    // C# is statically typed -- once a variable has a datat type, it cannot change

    // Float - float -- decimal numbers, +/- including 0.0

    // Double - double -- decimal numbers, +/-, including 0.0 <-- most commonly used decimal

    // Integers - int -- whole numbers, +/-, including 0

    // Variables are 'buckets' with a name to store data inside



    // Declaring (Creating variables) 
    // Method #1 -- Declared but not assigned
    // DataType variableName;

    int myInteger; 
    double myDouble; 


    // Method #2 -- Declare and Assign
    int myInteger2 = 1;
    double myDouble2 = 2.05D;


    // Method Strings -- Collections of letters, numbers, special characters
    string myString = "And this is my single";

    // Boolean -- bool - True or False values
    bool myBool = true; 
    bool fireResistance = false; 
    bool hasPurpleKey = true; 

    // Character -- char -- a single character
    char myChar = 'A';

    // Assign values after declaration
    myInteger = 5;
    myInteger = -1.0D

    // // Printing variables to the console terminal
    // Console.WriteLine(myInteger);
    // Console.WriteLine(myDouble);

    // // Printing expressions to the console terminal
    // Console.WriteLine(myInteger - 25);
    // Console.WriteLine(myDouble + 2.5D);

    // // Printing variables to the console terminal
    // Console.WriteLine(myInteger);
    // cCnsole.WriteLine(myDouble);

    // Operations -- Arithmetic

    int myNewInt = myInteger + myInteger2;
    double myNewDouble = myDouble + myDouble2;

    double myNewNumber = myInteger +myDouble;

    // Subtraction 
    myNewNumber = myDouble - myInteger;

    // Division
    myNewNumber = myDouble / myIntegers;

    // Multiplication
    myNewDouble = myDouble * myInteger;

    // Modulus -- Divides, then returns the remainder 
    // Most commonly used to determine even or odd
    myNewNumber = myDouble % 2;

    int students = 6;
    int numSlices = 36;
    int leftovers =;

    leftovers = numSlices % students;

    // Increment / Decrement -- Most frequently used in Loops
    int x = 0 
    x++; // What is x equal to now?
    // Increment ++ adds 1 to the current value and puts the new value into the bucket
  x--; 
  Decrement -- subtracts 1 from the current value and puts the new value into the bucket

  // Special Assignment Operators -- Takes current value, performes the calculate, and puts the new value in the bucket
  x += 1;
  x *- 1; 
  x /= 1;
  x -= 1;
  x %= 1;

// Comparrision Operations
// Elavulate the expression and return it as True or False
int y = 5;
int z = 3;

// // Is-Equal-To == is the value on the left equal to the value on the right
// Console.WriteLine (y == z);

// // Not equal to != is the value on the left not equal to the right?

// Console.WriteLine (y != z);

// // Greater than >
// Console.WriteLine (y > z);

// // Greater than or equall to >=
// Console.WriteLine (y >= z); 

// //  Less than
// Console.WriteLine (y < z);

// // Less than or equal to
// Console.WriteLine (y <= z);

// // Logical Operations 
// int b = 1;
// double c = 2.0D;
// string favColor = "Blue";

// Logical and && -- All statements must be true
// Console.WriteLine (b > 1 && c != 5.0D); // This is False
// Console.WriteLine (b == 1 && c < 10.0D); // This is true

// If one expression is most likely to be false, check for it first

// Console.WriteLine (hasPurpleKey == true && playerlevel > 5);

// Logical or || -- one statement must be true 
// Console.WriteLine (b > 1 || c != 5.0D); // Second statement is true, therfore the whole statement is true
// Console.WriteLine (b == 2 || c > 10.0D); // The whole statement is false

// If one expression is most likely to be true, check for it first
// Console.Writeline (hasBlueKey == true && playerLevel > 3);

// // Logical not ! -- Takes the opposite value of the expression
// Console.WriteLine (b > -1); //True
// Console.WriteLine (!(b > -1)); //True

// Reading user input from the console / terminal
Console.WriteLine ("What is your player name? Type it in and press enter.");

// Create a variable to store the date
string playerName = Console.ReadLine();       

// Console.ReadLine() only returns string date types 
Console.WriteLine ("What is your player name? Type it in and press enter.");
string age = Console.ReadLine;
Console.WriteLine (age + age);
//Adding string datat types together is called concatenation

// Print the vaiarble to the screen
Console.WriteLine ("Your player name is " + playerName);
Console.WriteLine ("How many stocks do you really have in stock? Enter an integer value and press enter.");
int numStocks = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine (numStocks + numStocks);









  }
}
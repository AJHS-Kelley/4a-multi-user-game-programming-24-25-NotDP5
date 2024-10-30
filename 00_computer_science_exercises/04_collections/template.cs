// Collections Example, David Ponder, v0.0
using System;
using System.Linq;
using System.Collections;

class Collections {
  static void Main() { // Do not delete
    
    /*
    -- In C#, a collection is known as as array.
    -- Each item in an array is known as an element. 
    -- Number of elements in an array can not be changed
    -- Contents in each element can chnage. 
    -- Arrays are ordered, meaning each item has a fixed position. 
    -- The position of the element is the index. 
    -- The first element index is a index. 
    */

    // Declaring and defining an array
    string [] breakfastFoods = {"Pancakes", "Eggs", "Waffle", "Bacon", "Cereal"};
    int [] testScores = {0, 25, 15, 75, 99};
    double[] GPA = {0.27D, 1.99D, 4.02D, 0.0D, 3.25D};

    // Print Array Content -- All Elements on Single Line 
    Console.WriteLine ("The elements of each array are:");
    Console.WriteLine (" ");
    Console.WriteLine ("breakFastFoods: \n" + String.Join("\n", breakfastFoods));
    Console.WriteLine (); // Print an empty line to the screen. 
    
    Console.WriteLine ("The elements of each array are:");
    Console.WriteLine (" ");
    Console.WriteLine ("testScores: \n" + String.Join("\n", testScores));
    Console.WriteLine (); // Print an empty line to the screen. 
    
    Console.WriteLine ("The elements of each array are:");
    Console.WriteLine (" ");
    Console.WriteLine ("GPA: \n" + String.Join("\n", GPA));
    Console.WriteLine (); // Print an empty line to the screen. 

    // How long is my array? Determing array length
    Console.WriteLine ("The length of the breakFastFoods array is: " + breakfastFoods.Length);
    Console.WriteLine ("The length of the testScores array is: " + testScores.Length);
    Console.WriteLine ("The length of the GPA array is: " + GPA.Length);



  } // NEVER CHANGE THIS LINE
} // NEVER CHANGE THIS LINE
// Collections Example, David Ponder, v0.0
using System;
using System.Linq;
using System.Collections;

class 04_Collections {
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
    string [] breakfast food = {"Pancakes", "Eggs", "Waffle", "Bacon", "Cereal"};
    int [] testScore = {0, 25, 15, 75, 99};
    double[] GPA = {0.27D, 1.99D, 4.02D, 0.0D, 3.25D};

    // Print Array Content -- All Elements on Single Line 
    Console.WriteLine ("The elements of eacg array are:");
    Console.WriteLine ("breakFastFoods: \n" + String.Join(", ", breakfastFoods));
    Console.WriteLine (); // Print an empty line to the screen. 



  } // NEVER CHANGE THIS LINE
} // NEVER CHANGE THIS LINE
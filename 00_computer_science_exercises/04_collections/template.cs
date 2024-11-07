// // // Collections Example, David Ponder, v0.0
// // using System;
// // using System.Linq;
// // using System.Collections;

// // class Collections {
// //   static void Main() { // Do not delete
    
// //     // /*
// //     // -- In C#, a collection is known as as array.
// //     // -- Each item in an array is known as an element. 
// //     // -- Number of elements in an array can not be changed
// //     // -- Contents in each element can chnage. 
// //     // -- Arrays are ordered, meaning each item has a fixed position. 
// //     // -- The position of the element is the index. 
// //     // -- The first element index is a index. 
// //     // */

// //     // // Declaring and defining an array
// //     // string [] breakfastFoods = {"Pancakes", "Eggs", "Waffle", "Bacon", "Cereal"};
// //     // int [] testScores = {0, 25, 15, 75, 99};
// //     // double[] GPA = {0.27D, 1.99D, 4.02D, 0.0D, 3.25D};

// //     // // Print Array Content -- All Elements on Single Line 
// //     // Console.WriteLine ("The elements of each array are:");
// //     // Console.WriteLine (" ");
// //     // Console.WriteLine ("breakFastFoods: \n" + String.Join("\n", breakfastFoods));
// //     // Console.WriteLine (); // Print an empty line to the screen. 
    
// //     // Console.WriteLine ("The elements of each array are:");
// //     // Console.WriteLine (" ");
// //     // Console.WriteLine ("testScores: \n" + String.Join("\n", testScores));
// //     // Console.WriteLine (); // Print an empty line to the screen. 
    
// //     // Console.WriteLine ("The elements of each array are:");
// //     // Console.WriteLine (" ");
// //     // Console.WriteLine ("GPA: \n" + String.Join("\n", GPA));
// //     // Console.WriteLine (); // Print an empty line to the screen. 

// //     // // How long is my array? Determing array length
// //     // Console.WriteLine ("The length of the breakFastFoods array is: " + breakfastFoods.Length);
// //     // Console.WriteLine ("The length of the testScores array is: " + testScores.Length);
// //     // Console.WriteLine ("The length of the GPA array is: " + GPA.Length);

// //     // Console.WriteLine (" ");
// //     // // .Length is known as a property of the array. 
// //     // // Accessing elements in the array with the index.
// //     // Console.WriteLine ("The first element in breakFast is: " + breakfastFoods[0]);
// //     // Console.WriteLine ("The first element in testScores is: " + testScores[3]);
// //     // Console.WriteLine ("The first element in GPA is: " + breakfastFoods[4]);
    
// //     // Console.WriteLine (" ");

// //     // // Shortcut to access the last item in an array
// //     // Console.WriteLine ("the last element of breakFastFoods is: " + breakfastFoods[breakfastFoods.Length - 1]);
// //     // Console.WriteLine ("the last element of testScores is: " + testScores[testScores.Length - 1]);
// //     // Console.WriteLine ("the last element of GPA is: " + GPA[GPA.Length - 1]);
    
// //     // // Changing elements in an array
// //     // breakfastFoods[2] = "Green Eggs and Ham";
// //     // testScores[0] = 56;
// //     // GPA[3] = 4.2D;
// //     // Console.WriteLine ("The elements of each array are:");
// //     // Console.WriteLine (" ");
// //     // Console.WriteLine ("breakFastFoods: \n" + String.Join("\n", breakfastFoods));
// //     // Console.WriteLine (); // Print an empty line to the screen. 
    

// //     // // Common errors with arrays
// //     // // Console.WriteLine (breakfastFoods[99]); // Index out of bounds -- According index that does not exist in the array
    
// //     // /*
// //     // testScores[0] = "99"; // Error message "Cannot implicitly convert dataType to dataType"
// //     // Console.WriteLine ("testScores: \n" + String.Join("\n", testScores));
// //     // Console.WriteLine (); // Print an empty line to the screen. 
// //     // */

// //     // // Sorting an array
// //     // int[] intArr = []













// //   // // Areray List -- Basically an array but you can add/remove elements from it. 
// //   // var exampleArrList = mew ArrayList();
// //   // // Adding elements to an array list use .Add()
// //   // Using .Add sends the new item to the end of the list
// //   // exampleArrList.Add(5);
// //   // exampleArrList.Add("Cars 3)");
// //   // exampleArrList.Add(false);
// //   // exampleArrList.Add(3.8D);

// //   // // Create Arraylist with values
// //   // var exampleArrList2 = new ArrayList()
// //   //   {
// //   //     -10, "Last name", "Purple", false, 25.25D, 195000, 0.0D
// //   //   };

// //   //   Console.WriteLine(exampleArrList[2]);
// //   //   Console.WriteLine(exampleArrList2[2]);

// //   // Inserting to a specific position in the ArrList
// //   // Use .Insert(index, value)
// //   exampleArrList.Insert(3, "Layups equal 2 points." \n);
// //   exampleArrList.Insert(0, -99)

// // .Remove(value) removes the first occurance of the item from the arraylist
// var newList = new ArrayList()
//     {
//         -10, 10, 15, -25, -10, 25, 33, -25, 40
//     };
// Console.WriteLine(newList[0]);
// newList.Remove(-10);
// Console.WriteLine(newList[0]);

// Deleting based on index number.
// .RemoveAt(value) -- deletes the item at the specified index
newList.RemoveAt(4);
// Delete the first item
newList.RemoveAt(0);
// Delete the last item
newList.RemoveAt(newList.Length - 1);

// Remove an entire range of elements. 
// .RemoveRange(firstIndex, LastIndex)
newList.RemoveRange(3,8);

// Shortcut to Delete from one item through the end of list.
newList,Range(4, newList.Length - 1);

// Does the arraylist contain a certain value
// .Contains(value) returns true if the list has that value, false otherwise.
new playerInventory = new Arraylist?()
    {
        "Helmet", "Shoulder Pads", "Cleats", "Gloves", "Socks", "Backplate"
    }; 

    Console.WriteLine(playerInventory.Contains("Towel"));
    Console.WriteLine(playerInventory.Contains("Gloves"));

    if (playerInventory.Contains("Cleats"))
    [
        // Do smt
    ]










// //   } // NEVER CHANGE THIS LINE
// // } // NEVER CHANGE THIS LINE
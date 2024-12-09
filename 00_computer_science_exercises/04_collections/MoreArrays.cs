using System;
using System.Linq;
using System.Collections;
class MoreArrays {
  static void Main() { // Do not delete

  // string[] colors = ["Red", "Orange", "Yellow", "Green", "Blue"];
  // // Loop through arrays -- The old way
  // for (int i = o; i < colors.Length; i++)
  // {
  //   Console.WriteLine(colors[i]);
  // }

  // // Looping through arrays -- the new botness. 
  // foreach (string i in colors)
  // {
  //   Console.WriteLine(i);
  // }
  
  // Loopiing through Array Practice
  // int[] numbers = {-1, 45, 786, 89, 32, 7, 980, 43, 898, 34};

  // foreach (int i in numbers)
  // {
  // if (i % 2 == 0) 
  // {
  //   Console.WriteLine("The number is even. \n");
  // }
  // else 
  // {
  //   Console.WriteLine("The number is odd. \n");
  // }
  // }

  // // Multidimensial Arrays 
  // // This class will only use 2 
  // int[,] nums = {{1, 3, 5}, {2, 4, 6}}

  // // Accessing elements in 2d array
  // Console.WriteLine(nums(0,1));
  // Console.WriteLine(nums(1,1));

  // // Changing elements in 2d arrays
  // nums[1,2] = 9001;
  // // Change any element from the first array
  // nums[0,2] = 7;

  // Looping through 2d arrays
  foreach (int i in nums)
  {
    Console.WriteLine(i);
  }

  // Looping through 2d arrays -- hard mode
  for (int i = 0; i < nums.GetLength(0); i++)
  {
    for (int j = 0; j < nums.GetLength(1); j++);
    {
      Console.WriteLine(nums[i,j]);
    }
  }








  } // NEVER CHANGE THIS LINE
} // NEVER CHANGE THIS LINE
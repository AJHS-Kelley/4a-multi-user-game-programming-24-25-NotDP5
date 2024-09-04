using System;
class Template {
  static void Main() {
    // These blocks of code are used to control how the program executes.
    // Basically, these blocks of code allow for decisions to be made

//     int age = 17;
//     double frenchFries = 1.25D;
//     string favFlavor = "Vanilla";
//     bool afraidSnakes = true;

//     // Can I vote?
//     if (age >= 18) // (age >= 18) is the conditional statement
//     {
//       Console.WriteLine ("You can vote!"); 
//     }
//     else if (age >= 16)
//     {
//       Console.WriteLine ("You are not old enough to vote but you can register.");
//     }
//     else
//     {
//       Console.WriteLine ("You are not old enough to vote");
//     }

//     /*
//     You can have a single if statement by itself
//     If you have an else you must also have an if
//     You can have as many else if statements as needed.0
//     For now, use the else condition to print an error message / log
//     */

//   int age;
//   if (age >= 0)
//   {
//     Console.WriteLine ("Age date stored")
//   }
//   else 
//   {
//     Console.WriteLine ("No age value detected. Please review")
//   }

// // Switch Statements
// int day = 1
// switch (day)

// {
//   case 1:
//     Console.WriteLine ("It's Monday");
//     break;
//   case 2: 
//     Console.WriteLine ("It's Tuesday");
//     break;
//   case 3: 
//     Console.WriteLine ("It's Wednesday");
//     break;
//   case 4: 
//     Console.WriteLine ("It's Thursday");
//     break;
//   case 5: 
//     Console.WriteLine ("It's Friday");
//     break;
//   case 6: 
//     Console.WriteLine ("It's Saturday");
//     break;
//   case 7: Console.WriteLine ("It's Sunday, go rest");
//     break;
// }

// Repeating steps over, and over, and over again
// Loops are used to repeat instructions multiple times

// While Loops are "musical chairs" in computer science
// use while loops if you do not how many loops you need
// the code will run as long as the condition is true
// while loop syntax:
/*
while (conditional_expression)
{
  Code loop goes here.
}

*/

// int z = 0;
// while (z <= 100) 
// {
//   Console.WriteLine(z);
//   z++;
// }

// int y = 100
// while (y >= 0)
// {
//   Console.WriteLine(y);
//   y--;
// }

// for loops are like playing go fish
// you know how many cards in your hands
// used when you know how many loops you need ahead of time\

/* 
for (statement 1; statement2; statement3)
{
  Code to run each time through loop
}

statement 1 = code to run one time before loop starts
statement 2 = conditional expression to check each time before the loop runs
statement 3 = code to run after each loop

each 'trip' through the loop is called an iteration 
*/

// Counting to 10 with for loops

// for (int i = 0; i <= 10; i++)
// {
//   Console.WriteLine(i);
// }

for (int i = 50; i >= 0; i--)
{
  Console.WriteLine(i);
}



  }
}
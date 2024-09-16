using System;
class GuessNumber {
  static void Main() {
    
int playerGuess = 0;
int maxGuess = 5;
int guess;

// Generate the secret number here
Random rnd = new Random(); // Create an object named "rnd" that is a copy of the Random() class
int secretNumber = rnd.Next(101); // Generate from 0 to 99 (Will be using this one for the project)
// int secretNumber = rnd.Next(25, 1000); // Generate 25 to 999 (This was an example)

while (playerGuess < maxGuess)
{
  // Console.WriteLine ("Secret Number: " + secretNumber);
  Console.WriteLine ("Please guess an integer between 0 and 100");
  guess = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine (guess);
  
  playerGuess++;
  if (guess < secretNumber)
  {
    Console.WriteLine ("Your guess is too low");
  }
  else if (guess > secretNumber)
  {
    Console.WriteLine ("Your guess is too high");
  }
  else 
  {
    Console.WriteLine ("You guessed correctly");
    break; // Keyword to immediately exit a loop
  }

if (playerGuess >= maxGuess)
{
  Console.WriteLine ("You have lost the game");
}

}
  // Allow the user to guess the number
  // Compare the guess to the secret number
  // If match, print win, if > or <, give a hint
  // +1 to playerGuess
  // Check if playerGuess > maxGuess
  // If true, print a "lose game" message, if false, guess again










  }
}
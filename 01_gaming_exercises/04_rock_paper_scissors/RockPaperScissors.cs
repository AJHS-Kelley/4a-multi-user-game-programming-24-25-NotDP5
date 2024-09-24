using System;
class Template {
  static void Main() {
   

// Player Variables
string playerName = "Test Name";
int playerScore = 0;
string playerChoice = "";

// CPU Variables
int cpuScore = 0;
string cpuChoice = "";

Console.WriteLine ("Welcome to my Rock, Paper, Scissors Bot!");
Console.WriteLine ("Please enter your name and hit enter.");
playerName = Console.ReadLine();
Console.WriteLine (" ");
Console.WriteLine ($"Hello {playerName}. Is that correct?");
Console.WriteLine ("Please type yes or no, then press enter.");
Console.WriteLine (" ");
string isCorrect = Console.ReadLine().ToLower();

if (isCorrect == "yes")
{
  Console.WriteLine (" ");
  Console.WriteLine ($"Great! I'll call you {playerName}.");
}
else if (isCorrect == "no")
{
  Console.WriteLine (" ");
  Console.WriteLine ("Please enter your name and hit enter.");
  playerName = Console.ReadLine();
}
else
{
  Console.WriteLine ($"Unable to process your request. Please truy again.");
}

Console.WriteLine (" ");
Console.WriteLine ("The rules for this bot:");
Console.WriteLine ("• You will choose Rock, Paper, or Scissors and the CPU will do the same at random.");
Console.WriteLine ("• A winner will be decided by the regular rock paper scissors rules:");
Console.WriteLine ("• Rock beats Scissors. Scissors beats Paper. Paper beats Rock.");
Console.WriteLine (" ");

Console.WriteLine ($"Do these rules make sense to you {playerName}? Select yes or no and hit enter.");
string isCorrect2 = Console.ReadLine().ToLower();
Console.WriteLine (" ");

if (isCorrect2 == "yes")
{
  Console.WriteLine ("Great!");
}
else
{
  Console.WriteLine ("Please reread the rules until they make sense and hit enter.");
  playerName = Console.ReadLine();
}

Console.WriteLine (" ");

Console.WriteLine ($"Are you ready to start the game {playerName}? Select yes or no and hit enter.");
string isCorrect3 = Console.ReadLine().ToLower();

if (isCorrect3 == "yes")
{
  Console.WriteLine (" ");
  Console.WriteLine ("Ok let's start!");
}
else
{
  Console.WriteLine (" ");
  Console.WriteLine ($"Oh well {playerName}, the game is starting! Hit enter to continue.");
  playerName = Console.ReadLine();
}


Console.WriteLine (" ");
while (playerScore < 5 && cpuScore < 5)
{
  //Print the scores.
  Console.WriteLine ($"Your Score: {playerScore} CPU Score: {cpuScore}");
  Console.WriteLine (" ");

  // Allow the player to select Rock, Paper, or Scissors.
  Console.WriteLine ("Please choose rock, paper, or scissors.");
  playerChoice = Console.ReadLine().ToLower();
  if (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
  {
  Console.WriteLine ("Please choose rock, paper, or scissors.");
  playerChoice = Console.ReadLine().ToLower();
  }

  // Allow CPU to select randomly.
  Random rnd = new Random();
  int cpuRand = rnd.Next(0,2);
  if (cpuRand == 0)
  {
    cpuChoice = "rock";
  }
  else if (cpuRand == 1)
  {
    cpuChoice = "paper";
  }
  else if (cpuRand == 2)
  {
    cpuChoice = "scissors";
  }
  else
  {
    Console.WriteLine ("Unable to determine a CPU choice.");
  }
  Console.WriteLine (" ");
  Console.WriteLine ($"CPU choice {cpuChoice}");
  // Compare the choices and determine a winner.
  if (playerChoice == "rock" && cpuChoice == "paper")
  {
    Console.WriteLine ($"You chose {playerChoice} and the CPU chose {cpuChoice}");
    Console.WriteLine ("The CPU won!");
    cpuScore++;
  }
  else if (playerChoice == "rock" && cpuChoice == "scissors")
  {
    Console.WriteLine (" ");
    Console.WriteLine ($"You chose {playerChoice} and the CPU chose {cpuChoice}");
    Console.WriteLine ("You win!");
    playerScore++;
  }
  else if (playerChoice == "rock" && cpuChoice == "rock")
  {
    Console.WriteLine (" ");
    Console.WriteLine ($"You chose {playerChoice} and the CPU chose {cpuChoice}");
    Console.WriteLine ("You and the CPU tied.");
  }
  else if (playerChoice == "paper" && cpuChoice == "rock")
  {
    Console.WriteLine (" ");
    Console.WriteLine ($"You chose {playerChoice} and the CPU chose {cpuChoice}");
    Console.WriteLine ("You win!");
    playerScore++;
  }
  else if (playerChoice == "paper" && cpuChoice == "scissors")
  {
    Console.WriteLine (" ");
    Console.WriteLine ($"You chose {playerChoice} and the CPU chose {cpuChoice}");
    Console.WriteLine ("The CPU won!");
    cpuScore++;
  }
  else if (playerChoice == "paper" && cpuChoice == "paper")
  {
    Console.WriteLine (" ");
    Console.WriteLine ($"You chose {playerChoice} and the CPU chose {cpuChoice}");
    Console.WriteLine ("You and the CPU tied.");
  }
    else if (playerChoice == "scissors" && cpuChoice == "rock")
  {
    Console.WriteLine (" ");
    Console.WriteLine ($"You chose {playerChoice} and the CPU chose {cpuChoice}");
    Console.WriteLine ("The CPU won.");
    cpuScore++;
  }
  else if (playerChoice == "scissors" && cpuChoice == "paper")
  {
    Console.WriteLine (" ");
    Console.WriteLine ($"You chose {playerChoice} and the CPU chose {cpuChoice}");
    Console.WriteLine ("You win!");
    playerScore++;
  }
  else if (playerChoice == "scissors" && cpuChoice == "scissors")
  {
    Console.WriteLine (" ");
    Console.WriteLine ($"You chose {playerChoice} and the CPU chose {cpuChoice}");
    Console.WriteLine ("You and the CPU tied.");
  }
  }
  // Output the results to the screen.
  // Give the winner a point.
}




  }
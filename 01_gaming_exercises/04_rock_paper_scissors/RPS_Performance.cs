using System;
class Template {
  static void Main() {
   

    // Player Variables
  int playerScore = 0;
  string playerChoice = "";
  int numDraws = 0;

  // CPU Variables
  int cpuScore = 0;
  string cpuChoice = "";

  Console.WriteLine ("Welcome to my Rock, Paper, Scissors Bot!");

  // Testing game loop
  int loopCount = 0;
  int loopReqs = 0; // Regs / Req is universal abbrav. for Request / Requests
  Console.WriteLine ("How many loops do you need? Type an integer and hit enter.");
  loopReqs = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine (" ");
  while (loopCount < loopReqs)
  { // LOOP STARTS HERE 
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

  } // LOOP ENDS HERE


// Lines 49 -- 113 need to be INSIDE the loop.  
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
    numDraws++;
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
    numDraws++;
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
    numDraws++;
  }
  }
	
  // Output the results to the screen.
  // Give the winner a point.
  loopCount++;
  
}

Console.WriteLine ($"Player Score: {playerScore}");
Console.WriteLine ($"CPU Score: {cpuScore}");
Console.WriteLine ($"Draws: {numDraws}");


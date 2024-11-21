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
  {
    Random rnd = new Random();
    int cpuRand = rnd.Next(0,2);
    if (playerRand == 0)
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

  }
    
  }
}
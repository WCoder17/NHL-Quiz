// Welcome to the quiz by Will
Console.Clear();

#nullable disable

// Welcome
Console.WriteLine("Welcome to the Quiz");

// Main Quiz
int corCount = 0;

// Question 1
Console.Write("\n1: When was the NHL Founded? ");
string ans1 = Console.ReadLine().ToLower();
if (ans1 == "1917")
{
    Console.WriteLine("Correct");
    corCount++;
}
else
{
    Console.WriteLine("Incorrect, the answer is 1917");
}

// Question 2
Console.Write("\n2: What is the name of the team that won the 2022 Stanley Cup? ");
string ans2 = Console.ReadLine().ToLower();
if (ans2 == "avalanche")
{
    Console.WriteLine("Correct");
    corCount++;
}
else
{
    Console.WriteLine("Incorrect, the answer is avalanche");
}

// Question 3
Console.Write("\n3: How many teams are in the NHL in 2023? ");
string ans3 = Console.ReadLine().ToLower();
if (ans3 == "32")
{
    Console.WriteLine("Correct");
    corCount++;
}
else
{
    Console.WriteLine("Incorrect, the answer is 32");
}

// Question 4
Console.Write("\n4: Name An NHL Team from Alberta: ");
string ans4 = Console.ReadLine().ToLower();
if (ans4 == "oilers")
{
    Console.WriteLine("Correct");
    corCount++;
}
else if (ans4 == "flames")
{
    Console.WriteLine("Correct");
    corCount++;
}
else
{
    Console.WriteLine("Incorrect, the oilers and the flames are from alberta");
}

// Final Score
int score = corCount;
Console.WriteLine($"Your Score is: {corCount} / 4 ({(score * 100) / 4}%)");
if (score <= 2 && score >= 1)
{
    Console.WriteLine("Ok Job");
}
else if (score > 2)
{
    Console.WriteLine("Well Done");
}
else
{
    Console.WriteLine("Do some Research and try again.");
}
Console.WriteLine("\nThanks for Doing the Quiz!");


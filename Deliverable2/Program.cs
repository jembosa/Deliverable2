
var sUserName = "";
var ans = "";
int iChallengeRound = 0;
int iCorrectAnswers = 0;

Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
Console.WriteLine("What is your name?");
sUserName = Console.ReadLine();
Console.WriteLine("Welcome " + sUserName + ". Do you want to do the COIN FLIP CHALLENGE? Yes/No");

while (true)
{
    ans = Console.ReadLine();
    if (ans != null && ans == "Yes")
    {
        break;
    }
    else if (ans != null && ans == "No")
    {
        Console.WriteLine("You are a coward " + sUserName);
        Console.ReadKey();
        return;
    }
    else
    {
        Console.WriteLine("Only Yes or No Allowed");
    }
}

//challenge five rounds
while (true && iChallengeRound < 5)
{
    Console.WriteLine("Heads or Tails?");
    ans = Console.ReadLine();
    if (ans != null && (ans == "Heads" || ans == "Tails"))
    {
        Random rand = new Random();

        if (rand.Next(0, 2) == 0)
        {
            //Console.WriteLine("Heads Random 0");
            if (ans == "Heads")
            {
                Console.WriteLine("Correct!");
                iCorrectAnswers = iCorrectAnswers + 1;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }
        else
        {
            //Console.WriteLine("Tails Random 1");
            if (ans == "Tails")
            {
                Console.WriteLine("Correct!");
                iCorrectAnswers = iCorrectAnswers + 1;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }

        iChallengeRound = iChallengeRound + 1;
    }
    else
    {
        Console.WriteLine("Only Heads or Tails Allowed");
    }
}

Console.WriteLine("\nThank you " + sUserName + ". You got a score of " + iCorrectAnswers + "!");
Console.ReadKey();



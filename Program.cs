// Fernando Aguilar
// 10-20-22
// Mini Challenge 8 Guess It Endpoint
// Create a program that runs a Guessing Game where the user will 
// choose a difficulty and guess a number between 1-10, 1-50, or 1-100.
// The program will track the number of guesses it took to get to the right number.
// Include data validation and the ability to play again.
// Peer Reviewed By:

Console.Clear();

string playAgain = "yes";
while(playAgain == "yes"){
int easyLvl = 11;
int mediumLvl = 51;
int hardLvl = 101;
int winningNum = 0;
int gameMaxNum = 0;
int numGuess = 0;
string userInput;
string option;
bool validNum = false;
int guessCount = 0;

Console.Clear();

Console.WriteLine(" Time to test your luck with Freddy's Guessing Game! Feeling lucky? ");
Console.WriteLine(" Select your difficulty: ");
Console.WriteLine(" Apprentice, Guessing from 1-10? ");
Console.WriteLine(" Adept, guessing from 1-50? ");
Console.WriteLine(" Expert, guessing from 1-100? ");
option = Console.ReadLine().ToLower();

while (option != "apprentice".ToLower() && option != "adept".ToLower() && option != "expert".ToLower())
{
    Console.WriteLine(" Invalid input, want to try again? ");
    option = Console.ReadLine();
}

Console.WriteLine(" You chose " + option + " difficulty. ");

Random random = new Random();

if (option == "apprentice")
{
    winningNum = random.Next(0, easyLvl);
    gameMaxNum = easyLvl - 1;
}
if (option == "adept")
{
    winningNum = random.Next(0, mediumLvl);
    gameMaxNum = mediumLvl - 1;
}
if (option == "expert")
{
    winningNum = random.Next(0, hardLvl);
    gameMaxNum = hardLvl - 1;
}
while(numGuess != winningNum){
while (validNum == false)
{
    Console.WriteLine("Choose a number from 1 to " + gameMaxNum);
    userInput = Console.ReadLine();
    guessCount++;
    validNum = Int32.TryParse(userInput, out numGuess);

    if (validNum == true)
    {
        if ((numGuess <= gameMaxNum) && (numGuess >= 1))
        {
            validNum = true;
        }
        else
        {
            Console.WriteLine(" Pick a number. ");
            validNum = false;
        }
    }
    else
    {
        Console.WriteLine(" Invalid entry. Please pick a number! ");
    }
}

if (numGuess == winningNum)
{
    Console.WriteLine(" The winning number was " + winningNum + ", great work! ");
}
else if (numGuess > winningNum)
{
    Console.WriteLine(" That number is too high! Try again! ");
    validNum = false;
}
else 
{
    Console.WriteLine(" That number is too low! Try Again! ");
    validNum = false;
}

}
Console.WriteLine( " It took you " + guessCount + " tries to win the game! Your pretty good at this! ");
Console.WriteLine( " Would you like to try your luck again? yes or no?");
playAgain = Console.ReadLine().ToLower();
if(playAgain == "no".ToLower())
{
    Console.WriteLine(" Thanks for playing! Good bye! ");
    break;
}
}



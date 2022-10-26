//Peer review: Zac Rice
//comment: Works great and functions as intended!

bool letsPlay = true;

while(letsPlay == true)
{
int number;

Console.WriteLine("Please enter a number.");
number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0){
    Console.WriteLine(number + " is an even number.");
}
else{
    Console.WriteLine(number + " is an odd number.");
}
bool question = true;
while(question == true)
{
Console.WriteLine("Do you want to play again? Y/N");
string playAgain = Console.ReadLine().ToUpper();

if(playAgain == "Y")
{
    letsPlay = true;
    question = false;
}
else if(playAgain == "N")
{
    letsPlay = false;
    question = false;
    Console.WriteLine("Goodbye.");
}
else
{
    Console.WriteLine("Please enter a valid option: Y or N");
    question = true;
}
}
}
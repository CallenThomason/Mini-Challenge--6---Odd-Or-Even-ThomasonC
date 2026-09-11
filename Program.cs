/*
Callen Thomason
9/11/2026
Mini Challenge #6 - Odd or Even
I was able to check if a number input by a user was odd or even using the modulo, and an if else statment.
Then I asked the player if they wanted to play again using a do while loop and a while loop to check if they input a valid answer. 
Also used .ToUpper to make 'y' and 'n' acceptable answers. 
Peer Revwier: Valery Lot
Review: Thorough flow chart. Code is clean and concise. Also, great idea to end with "thank you for playing" when user wants to stop playing.
*/

Console.Clear(); 

Console.WriteLine("Welcome to odd or even"); 
String ans;
do
{

Console.Write("Please enter a number: "); 
String num = Console.ReadLine();  
int realNum = Convert.ToInt32(num); 
int math = realNum % 2; 
if(math == 1)
    {
       Console.WriteLine($"{realNum} is odd"); 
    }//end if
    else
    {
     Console.WriteLine($"{realNum} is even");   
    }//end else
    Console.WriteLine("Do you want to play again? Y / N");
     ans = Console.ReadLine().ToUpper(); 
     while(ans != "Y" && ans != "N")
    {
        Console.WriteLine("Invalid input. Please answer Y / N");
         ans = Console.ReadLine().ToUpper(); 
    }

}while(ans == "Y"); 

Console.WriteLine("Thank you for playing"); 


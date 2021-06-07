using System;

namespace CodeAcademy___Boolean_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
//TASK1 - IS 500 GREATER THAN 24?
            //Define the numbers
            int firstnum = 24;
            int secondnum = 500;
            bool answerOne = (firstnum < secondnum);
            Console.WriteLine($"True or false: The number 500 is greater than 24? {answerOne}.");

//TASK2 - DOES THE WORD "COFFEE" CONTAIN THE LETTER A?
// Ask user what their drink is
            Console.WriteLine("What are you drinking?");
            string drink = Console.ReadLine();           
            string checkword = "a";
// Find position of checkword within the user's string
            int DrinkCheck = drink.IndexOf(checkword);
/* If the checkword is found, it will be 0 or above (because it's within the 
            index). Drive a TRUE/FALSE boolean on this basis
*/
            bool LetterCheck = (DrinkCheck >= 0);          
 // Print results
            Console.WriteLine($"The drink is {drink}, " +
            $"does it contain the letter {checkword}? {LetterCheck}.");

//TASK3 - COMPARISON OPERATORS
            int num1 = 14;
            int num2 = 14;
            int num3 = 8;
// Equals ==: returns true if the value to the left is equal to the value to the right.
            bool equals = (num1 == num2);
            Console.WriteLine($"Is num1 and num2 equal? " + equals);
// Inequality operator !=: returns true if the two values are not equal.
            bool inequal = (num1 != num2);
            Console.WriteLine($"Are num1 and num2 not equal? " + inequal);
/* Less than<: returns true if the value to the left is less 
   than the value to the right.
   Less than or equal to <=: returns true if the value to the left is less than 
   or equal to the value on the right.
   Greater than or equal to >=: returns true if the value to the left is more than
   or equal to the value to the right.
*/
            bool lessthan = (num3 < num2);
            Console.WriteLine($"Is num3 less than num2? " + lessthan);

//TASK4 - TRUTH TABLE - LOGICAL OPERATORS
/* Logical operators include:
AND &&: Both expressions are evaluated and will return True only if both expressions 
    evaluate to True. Otherwise, it will return False.
OR ||: Both expressions are evaluated and will return True if at least one of the expressions
    evaluates to True. Otherwise, it will return False.
NOT !: An expression, no matter its logical value, evaluates to its opposite. 
    What is True becomes False and what is False becomes True.
*/
            bool andExample = ((4 > 1) && (2 < 7));
// (True AND True) evaluates to True
            bool orExample = ((8 > 6) || (3 > 6));
// (True OR False) evaluates to True
            bool notExample = !(1 < 3);
// NOT (True) evaluates to False
            Console.WriteLine
           ($"Example of and: {andExample} \n" +
            $"Example of or:  {orExample} \n"  +
            $"Example of Not: {notExample} \n");
// Exercise - the holiday
            bool beach = true;
            bool hiking = false;
            bool city = true;
// I want beach and city (bool comes out as True)
            bool yourNeeds = (beach && city);
// Friend wants beach or hiking (bool comes out as True)
            bool friendNeeds = (beach || hiking);
// My needs and Friend Needs (True and True)
            bool tripDecision = (yourNeeds && friendNeeds);
            Console.WriteLine(tripDecision);
        }
    }
}

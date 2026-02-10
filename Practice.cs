using System;

class Practice
{
    static void Main()
    {   
        // string name = "Jerathel";
        // string hobby = "building apps";
        // int age = 35;
        // Console.WriteLine("Hello, my name is " + name + ", my favorite hobby is " + hobby + " and I am " + age + " years old.");

        // if (age < 35)
        // {
        //     Console.WriteLine("You're younger than " + age);
        // }
        // else if (age == 35)
        // {
        //     Console.WriteLine("You're exactly " + age);
        // }
        // else
        // {
        //     Console.WriteLine("You're older than " + age);
        // }
// ==================================================================================================================
// Write a program that asks for a user’s score (0–100).

// Print "Fail" if it’s below 60, "Pass" for 60–79, and "Excellent" for 80 and above.

// You can use a variable like int score = 85; for now.

// Give it a shot!
// ===================================================================================================================
// Console.WriteLine("Please enter your score (0-100):");

// int score = 85;

// if (score < 60)
//         {
//             Console.WriteLine("Your score is Fail!");
//         }
// else if (score >= 60 && score <= 79)
//         {
//             Console.WriteLine("Your score is Pass!");
//         }
// else
//         {
//             Console.WriteLine("Your score is Excellent!");
//         }
// ====================================================================================================================
// Write a program that asks for three test scores.

// Average them, then print:

// "Needs Improvement" if the average is below 70
// "Satisfactory" if it’s 70–84
// "Outstanding" if it’s 85 or above.
// ====================================================================================================================
// Console.WriteLine("Please enter your test score: ");
// int score = int.Parse(Console.ReadLine());

// if (score < 70)
//         {
//             Console.WriteLine("Your score needs improvement");
//         }
//         else if (score >= 70 && score <= 84)
//         {
//             Console.WriteLine("Your score is satisfactory");
//         }
//         else
//         {
//             Console.WriteLine("Your score is outstanding");
//         }

// ====================================================================================================================
//Write a program that asks the user for their annual income and age.
// If income is above $50,000 and age is under 30, print "High earner, young professional."
// If income is below $25,000 and age is over 60, print "Eligible for senior support."
// For all other cases, print "Standard applicant."

// Console.WriteLine("Please enter your annual income: ");
// int income = int.Parse(Console.ReadLine());

// Console.WriteLine("Please enter your age: ");
// int age = int.Parse(Console.ReadLine());

// if (income > 50000 && age < 30)
//         {
//             Console.WriteLine("High earner, young professional.");
//         }
// else if (income < 25000 && age > 60)
//         {
//             Console.WriteLine("Eligible for senior support.");
//         }
// else
//         {
//             Console.WriteLine("Standard applicant.");
//         }
// ======================================================================================================================================
// Write a program that asks for three numbers.

// Print out which one is the largest, and if two or all three are equal, print a message saying so.

// Try to cover every possible case—even if all three numbers are the same.
// Console.WriteLine("You're required to enter three numbers.");
// Console.WriteLine("Please enter the first number: ");
// int firstNum = int.Parse(Console.ReadLine());

// Console.WriteLine("Please enter the second number: ");
// int secondNum = int.Parse(Console.ReadLine());

// Console.WriteLine("Please enter the third number: ");
// int thirdNum = int.Parse(Console.ReadLine());

// if (firstNum == secondNum && firstNum == thirdNum)
//         {
//              Console.WriteLine("All three numbers are equal.");
//         }
// else if (firstNum >= secondNum && firstNum >= thirdNum)
//         {
//             if (firstNum == secondNum)
//             {
//                 Console.WriteLine(firstNum + " and " + secondNum + " are equal and the largest numbers.");
//             }
//             else if (firstNum == thirdNum)
//             {
//                 Console.WriteLine(firstNum + " and" + thirdNum + " are equal and the largest numbers.");
//             }
//             else
//             {
//                 Console.WriteLine(firstNum + " is the largest number.");
//             }
//         }
// else if (secondNum >= firstNum && secondNum >= thirdNum)
//             {
//                 if (secondNum == firstNum)
//                 {
//                     Console.WriteLine(secondNum + " and" + firstNum + " are equal and the largest numbers.");
//                 }
//                 else if (secondNum == thirdNum)
//                 {
//                     Console.WriteLine(secondNum + " and" + thirdNum + " are equal and the largest numbers.");
//                 }
//                 else
//                 {
//                     Console.WriteLine(secondNum + "is the largest number.");
//                 }
//             }
// else
//         {
//             Console.WriteLine(thirdNum + " is the largest number.");
//         }
// ===============================================================================================================================
// Write a program that asks for a person’s age and annual income.

// Then:
// If age is under 18, print “Minor” and stop.
// If age is 65 or older and income is less than $30,000, print “Senior eligible for aid.”
// If age is 65 or older and income is $30,000 or more, print “Senior, not eligible for aid.”
// If age is between 18 and 64:
// If income is below $20,000, print “Adult, low income.”
// If income is between $20,000 and $100,000, print “Adult, middle income.”
// If income is over $100,000, print “Adult, high income.”

Console.WriteLine("What's your age?");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("What's your annual income?");
double income = double.Parse(Console.ReadLine());

if (age < 18)
    {
        Console.WriteLine("Minor");
    }
else if (age >= 65 && income < 30000)
        {
            Console.WriteLine("Senior eligible for aid.");
        }
else if (age >= 65 && income >= 30000)
        {
            Console.WriteLine("Senior not eligible for aid.");
        }
else if (age >= 18 && age <= 64)
        {
        if (income < 20000)
            {
                Console.WriteLine("Adult, low income.");
            }
        else if (income >= 20000 && income <= 100000)
            {
                Console.WriteLine("Adult, middle income.");
            }
        else
            {
                Console.WriteLine("Adult, high income.");
            }
        }
        }
    }




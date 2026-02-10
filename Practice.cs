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

Console.WriteLine("Please enter your annual income: ");
int income = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter your age: ");
int age = int.Parse(Console.ReadLine());

if (income > 50000 && age < 30)
        {
            Console.WriteLine("High earner, young professional.");
        }
else if (income < 25000 && age > 60)
        {
            Console.WriteLine("Eligible for senior support.");
        }
else
        {
            Console.WriteLine("Standard applicant.");
        }
    }


}

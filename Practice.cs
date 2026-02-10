using System;

class Practice
{
    static void Main()
    {   
        string name = "Jerathel";
        string hobby = "building apps";
        int age = 35;
        Console.WriteLine("Hello, my name is " + name + ", my favorite hobby is " + hobby + " and I am " + age + " years old.");

        if (age < 35)
        {
            Console.WriteLine("You're younger than " + age);
        }
        else if (age == 35)
        {
            Console.WriteLine("You're exactly " + age);
        }
        else
        {
            Console.WriteLine("You're older than " + age);
        }
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
Console.WriteLine("Please enter your test score: ");
int score = int.Parse(Console.ReadLine());

if (score < 70)
        {
            Console.WriteLine("Your score needs improvement");
        }
        else if (score >= 70 && score <= 84)
        {
            Console.WriteLine("Your score is satisfactory");
        }
        else
        {
            Console.WriteLine("Your score is outstanding");
        }
    }


}

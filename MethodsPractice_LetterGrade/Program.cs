/* Purpose:  Modify an earlier program that will prompt the user for a student’s name and their mark. The
program should display the student’s name along with a letter grade calculated using the
following table:
Mark Letter Grade
100 - 90 A
89 - 80 B
79 - 70 C
69 - 50 D
49 - 0 F
Input: name, mark
output: lettergrade
author: Mihiri Kamiss
date: oct 14, 2022
*/


using System.Reflection.Metadata;

namespace MethodsPractice_LetterGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int  MaxValue = 100,
                MinValue = 0;
            int mark;
            string name;
            char letterGrade;

            //input name and mark
            name = GetSafeString("Enter the student's name: ");
            mark = GetSafeInt("Enter student's mark: ", MaxValue, MinValue);

            //determine letter grade
            letterGrade = LetterGradeFromMark(mark);

            //display results
            Console.WriteLine($"Student: {name} \nGrade: {letterGrade}");

            Console.ReadLine();
        }//end of main

        static char LetterGradeFromMark(int mark)
        {
            char letter;

            if (mark >= 90)
            {
                letter = 'A';
            }else if (mark >= 80)
            {
                letter = 'B';
            }
            else if (mark >= 70)
            {
                letter = 'C';
            }else if (mark >= 50)
            {
                letter = 'D';
            }else
            {
                letter = 'F';
            }
            return letter;
        }//end of LetterGradeFromMark

        static int GetSafeInt(string prompt, int maxValue, int minValue)
        {
            bool isValid = false;
            int number;
            do
            {
                try
                {
                    Console.Write(prompt);
                    number = int.Parse(Console.ReadLine());
                    if (number <= maxValue && number >= minValue)
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine($"The number {number} not between {maxValue} and {minValue} inclusive...please try again.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input ... please try again.");
                    number = 0;
                }
            } while (!isValid);
            return number;
        }//end of GetSafeInt

        static string GetSafeString(string prompt)
        {
            bool isValid = false;
            string text;
            do
            {
                Console.Write(prompt);
                text = (Console.ReadLine());
                if (text.Length > 0)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine($"The name cannot be blank...please try again.");
                }
                

            } while (!isValid);

            return text;
        }//end of GetSafeString
     }
}
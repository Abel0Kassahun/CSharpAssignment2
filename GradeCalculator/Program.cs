using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean checker;
            double grade;
            string lettergrade=" ";
            int numberOfGrades;
             
            Console.WriteLine("How many students grades would you like to calculate?");
            do
            {
                numberOfGrades = Convert.ToInt32(Console.ReadLine());
                if (numberOfGrades <= 0)
                {
                    Console.WriteLine("Your input should be greater than 0, try again");
                }
            } while (numberOfGrades <= 0);
            
            for (int i = 0; i < numberOfGrades; i++)
            {
                Console.WriteLine("Enter student number" + (i+1)+"'s grade out of 100%: ");
                do
                {
                    checker = true;
                    grade = Convert.ToDouble(Console.ReadLine());
                    if (grade < 0.0 || grade > 100.0)
                    {
                        Console.WriteLine("Your input grade should be between 0 and 100, Try again");
                        checker = false;
                    }
                } while (!checker);

                if (grade <= 100.0 && grade >= 90.0)
                {
                    lettergrade = "A+";
                }
                else if (grade < 90.0 && grade >= 80.0)
                {
                    lettergrade = "A";
                }
                else if (grade < 80.0 && grade >= 75.0)
                {
                    lettergrade = "B+";
                }
                else if (grade < 75.0 && grade >= 70.0)
                {
                    lettergrade = "B";
                }
                else if (grade < 70.0 && grade >= 65.0)
                {
                    lettergrade = "C+";
                }
                else if (grade < 65.0 && grade >= 60.0)
                {
                    lettergrade = "C";
                }
                else if (grade < 60.0 && grade >= 55.0)
                {
                    lettergrade = "D+";
                }
                else if (grade < 55.0 && grade >= 50.0)
                {
                    lettergrade = "D";
                }
                else if (grade < 50.0)
                {
                    lettergrade = "F";
                }
            }
            
            for(int i = 0; i < numberOfGrades; i++)
            {
                Console.WriteLine( "Student " + (i + 1) + "'s letter grade is :" + lettergrade);
            }
        }
    }
}

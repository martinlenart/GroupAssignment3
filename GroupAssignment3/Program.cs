using System;

namespace GroupAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentList myStudents = new StudentList();
            Console.WriteLine("Empty student list");
            Console.WriteLine(myStudents);

            Console.WriteLine("\nStudent list");
            myStudents.InitiateOOP1dotNet5();
            Console.WriteLine(myStudents);

            Console.WriteLine("\nSorted student list");
            myStudents.Sort();
            Console.WriteLine(myStudents);
            Console.WriteLine();
            
            int NrOfGroups = 0;
            bool Continue = UserInput.TryReadInt32("How many groups do you want", 2, myStudents.Count / 2, out NrOfGroups);

            if (!Continue) return;

            myStudents.CreateGroups(NrOfGroups);
            Console.WriteLine($"If I make {NrOfGroups}, each group will have {myStudents.NrInGroup} students and {myStudents.NrNotInGroup} student remaining");

        }

    }

    //Exercise Sprint 1
    //1. Properties and Methods of class StudentList
    //2. How do I keep track of NrOfStudents
    //3. How do I initiate students in InitiateOOP1dotNet5()
    //4. What changes do I need to make in "Selection Sort" From BOOP_05_07 to implement Sort()
}

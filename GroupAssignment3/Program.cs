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

            Console.WriteLine("\nScrambled student list");
            myStudents.Scramble();
            Console.WriteLine(myStudents);
            Console.WriteLine();

            int NrOfGroups = 0;
            bool Continue = UserInput.TryReadInt32("How many groups do you want", 2, myStudents.Count / 2, out NrOfGroups);

            if (!Continue) return;

            myStudents.CreateGroups(NrOfGroups);
            Console.WriteLine($"{NrOfGroups} groups, each group will have {myStudents.NrInGroup} students and {myStudents.NrNotInGroup} student remaining");

            for (int gr = 0; gr < myStudents.NrOfGroups; gr++)
            {
                Console.WriteLine($"\nGroup {gr}:");
                foreach (var item in myStudents.GetGroup(gr))
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine($"\nRemain to group {myStudents.NrNotInGroup}:");
            foreach (var item in myStudents.RemainToGroup())
            {
                Console.WriteLine(item);
            }

        }

    }

    //Exercise Sprint 1
    //1. Properties and Methods of class StudentList
    //2. How do I keep track of NrOfStudents
    //3. How do I initiate students in InitiateOOP1dotNet5()
    //4. What changes do I need to make in "Selection Sort" From BOOP_05_07 to implement Sort()
}

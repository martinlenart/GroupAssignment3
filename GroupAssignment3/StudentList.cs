using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment3
{
    class StudentList
    {
        const int MaxNrOfStudents = 50;
        string[] students;

        private int _count = 0;
        public int Count => _count;

        private int _nrOfGroups = 0;
        public int NrOfGroups => _nrOfGroups;

        public int NrInGroup => Count / NrOfGroups;
        public int NrNotInGroup => Count % NrOfGroups;

        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < _count; i++)
            {
                sRet += $"{students[i],-15}";
                if ((i + 1) % 5 == 0)
                    sRet += "\n";
            }
            return sRet;
        }

        public void InitiateOOP1dotNet5()
        {
            students = new string[MaxNrOfStudents];
            students[0] = "Sahar";
            students[1] = "Jennifer";
            students[2] = "Shohruh";
            students[3] = "Jonathan";
            students[4] = "Leo";
            students[5] = "Jenny";
            students[6] = "Mohamed";
            students[7] = "Ferri";
            students[8] = "Alexandra F";
            students[9] = "Vidar";
            students[10] = "Kamran";
            students[11] = "Kaveh";
            students[12] = "Maria";
            students[13] = "Sophie";
            students[14] = "Louise";
            students[15] = "Fredric";
            students[16] = "Carl-Henrik";
            students[17] = "Frans";
            students[18] = "Sam";
            students[19] = "Alexandra S";
            students[20] = "Alperen";
            students[21] = "Josefine";
            students[22] = "Ghasem";
            students[23] = "Hanna";
            students[24] = "Finan";
            students[25] = "Niklas";
            students[26] = "Hector";
            students[27] = "Fredrik";
            students[28] = "Teodor";

            _count = 29;
        }

        //Selection Sort From BOOP_05_07
        public void Sort()
        {
            for (int unsortedStart = 0; unsortedStart < _count - 1; unsortedStart++)
            {
                // ViewPoint A
                int minIndex = unsortedStart;
                string minValue = students[unsortedStart];

                //Iterate over the unsorted part
                for (int i = unsortedStart + 1; i < _count; i++)
                {
                    //Find the smalest element in the unsorted part
                    if (students[i].CompareTo(minValue) < 0)
                    {
                        minIndex = i;
                        minValue = students[i];
                    }
                }

                // Swap the smalest element with the 
                (students[unsortedStart], students[minIndex]) = (students[minIndex], students[unsortedStart]);
            }
        }

        public void CreateGroups(int NrOfGroups)
        {
            if (NrOfGroups < 2 || NrOfGroups > Count / 2)
                throw new Exception("Wrong number of groups");

            _nrOfGroups = NrOfGroups;
        }
    }
}

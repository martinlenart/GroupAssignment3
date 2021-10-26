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

        string[][] _groups;
        public string[] GetGroup(int groupNr) => _groups[groupNr];

        string[] _remainToGroup;
        public string[] RemainToGroup() => _remainToGroup;

        #region ToString() related
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
        #endregion

        #region Initialization related
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
        #endregion

        #region Selection Sort From BOOP_05_07
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
        #endregion

        #region Create Groups related
        public void Scramble()
        {
            var rnd = new Random();
            //Swap 1000 times go get a good scramble
            for (int i = 0; i < 1000; i++)
            {
                //get to random positins in studentlist
                int idx1 = rnd.Next(0, Count);
                int idx2 = rnd.Next(0, Count);

                //swap the content of the random positions
                (students[idx1], students[idx2]) = (students[idx2], students[idx1]);
            }
        }
        public void CreateGroups(int NrOfGroups)
        {
            if (NrOfGroups < 2 || NrOfGroups > Count / 2)
                throw new Exception("Wrong number of groups");

            //Set the backing field
            _nrOfGroups = NrOfGroups;

            //create the multidimensional jagged group array
            _groups = new string[NrOfGroups][];
            _remainToGroup = new string[NrNotInGroup];

            //copy students into _group according to NrOfGroups and NrInGroup
            int originalStudentIdx = 0;
            for (int group = 0; group < NrOfGroups; group++)
            {
                _groups[group] = new string[NrInGroup];
                for (int individ = 0; individ < NrInGroup; individ++)
                {
                    _groups[group][individ] = students[originalStudentIdx];
                    originalStudentIdx++;
                }
            }

            //copy the remaining students into _remaintogroup, could be none
            int r = 0;
            while (originalStudentIdx < Count)
            {
                _remainToGroup[r] = students[originalStudentIdx];
                r++;
                originalStudentIdx++;

            }
        }
        #endregion

    }
}

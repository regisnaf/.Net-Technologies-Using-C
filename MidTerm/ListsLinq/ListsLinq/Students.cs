using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListsAndLINQ;

namespace ListsLinq
{
    class Students
    {
        private string StudentID;

        private string First_Name;

        private string Last_Name;

        private int[] scores;

        private static string[] subjects = { "Math", "Biology", "Chemistry", "English", "History" };

        //Accessors and mutators

        public string _StudentID{ get { return StudentID; } set { StudentID = value; }}

        public string _First_Name{get { return First_Name; } set { First_Name = value; }}

        public string _Last_Name{get { return Last_Name; } set { Last_Name = value; }}

        public int[] _scores{get { return scores; } set { scores = value; }}
    }
}


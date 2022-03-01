using System;

using System.Linq;

using System.Collections.Generic;
using ListsAndLINQ;
using ListsLinq;

namespace ListsAndLINQ

{
    public class Lists
    {
        private List<Students> Students;
        public Lists()

        {
            Students = new List<Students>()
            {
            new Students{_StudentID = "1001",_First_Name = "Mark",_Last_Name = "Buffon",_scores = new int[]{78, 80, 72, 84, 88}},
            new Students{_StudentID = "1002",_First_Name = "Julia",_Last_Name = "Roberts",_scores = new int[]{74, 81, 56, 83, 90}},
            new Students{_StudentID = "1003",_First_Name = "Maria",_Last_Name = "Randolph",_scores = new int[]{80, 77, 65, 91, 93}},
            new Students{_StudentID = "1004",_First_Name = "John",_Last_Name = "Bain",_scores = new int[]{73, 71, 67, 55, 81}},
            new Students{_StudentID = "1005",_First_Name = "Mark",_Last_Name = "Buffon",_scores = new int[]{90, 89, 82, 74, 83}}
            };
        }

        public class AscendingAverage : IComparer<Students>

        {
            int IComparer<Students>.Compare(Students x, Students y)
            {
                if (x._scores.Average() < y._scores.Average())
                    return 1;
                else if (x._scores.Average() > y._scores.Average())
                    return -1;
                else
                    return 0;
            }
        }

        public void DivisibleByTwo()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var numQuery = from num in arr
                           where (num % 2) == 0
                           select num;
            Console.WriteLine("DivisibleByTwo Results: ");
            foreach (int num in numQuery)              
                Console.Write("{0,1}", num);
        }

        public void NumbersInRange()
        {
            List<int> list = new List<int>()
            { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14};
            var numQuery = from num in list
                           where num > 0 && num < 12
                           orderby num descending
                           select num;

            Console.WriteLine();
            Console.WriteLine("NumbersInRange: ");
            foreach (int num in numQuery)
            Console.Write("{0,1} ", num);
        }

        public void CityInformation()
        {
            string start, end;
            string[] cities =
            {"ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS"};
            Console.WriteLine("\nThe cities are: {0}", string.Join(", ", cities));
            Console.WriteLine("\nEnter starting character");
            start = Console.ReadLine();
            Console.WriteLine("\nEnter ending character");
            end = Console.ReadLine();
            var cityQuery = cities.Where(r => r.StartsWith(start) || r.EndsWith(end));

            if (cityQuery.Any())
            {
                foreach (string city in cityQuery)
                    Console.Write("{0,1} ", city);
            }
            else
            {
                Console.Write("No city found");
            }
        }

        public void displayNameAndScores()
        {
            Console.WriteLine();

            Students.Sort(new AscendingAverage());
            Console.WriteLine("\nStudent Averages: ");
            foreach (Students stud in Students)
            {
                Console.Write(stud._First_Name + " - "  + stud._scores.Average() + "; ");
            }
        }

        public void displaySubjectNameAndAverage()
        {
            Console.WriteLine();
            Console.WriteLine("\nSubject Average: ");
            int i = 0;
            double sum = 0.0;
            string[] subjects = { "Math", "Biology", "Chemistry", "English", "History" };
            foreach (string subject in subjects)
            {
                foreach (Students stud in Students)
                {
                    sum = sum + stud._scores[i];
                }
                Console.Write( subject + " - " +  sum / Students.Count + "; ");
                sum = 0;
                i++;
            }

        }

        public void displayStudentsAndHighestAndLowestAverage()
        {
            Console.WriteLine();
            int Last = Students.Count - 1;

            Console.WriteLine("\nLowest Score: ");
            Console.WriteLine(Students[Last]._First_Name + " " + Students[Last]._Last_Name + " " + Students[Last]._scores.Average());
            Console.WriteLine("\nHighest Score:");
            Console.WriteLine(Students[0]._First_Name + " " + Students[0]._Last_Name + " " + Students[0]._scores.Average());
        }

        public void displaySubjectAndHighestAndLowest()
        {
            Console.WriteLine();
            int i = 0;
            int highest = 0, lowest = 100;
            Students high = null, low = null;
            string[] subjects = { "Math", "Biology", "Chemistry", "English", "History" };

            foreach (string subject in subjects)
            {
                foreach (Students stud in Students)
                {
                    if (stud._scores[i] > highest)
                    {
                        highest = stud._scores[i];
                        high = stud;
                    }
                    if (stud._scores[i] < lowest)
                    {
                        lowest = stud._scores[i];
                        low = stud;
                    }

                }
                Console.WriteLine("Highest/Lowest Subject Scores: ");
                Console.WriteLine(subject + " : " + "Highest: " + high._First_Name + " " + high._Last_Name + " " + highest);
                Console.WriteLine(subject + " : " + "Lowest: " + low._First_Name + " " + low._Last_Name + " " + lowest);

                i++;

                highest = 0;
                lowest = 100;
            }

        }
    }
}

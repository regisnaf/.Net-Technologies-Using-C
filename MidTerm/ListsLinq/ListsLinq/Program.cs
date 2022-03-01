using ListsAndLINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Lists lin = new Lists();

            lin.DivisibleByTwo();

            lin.NumbersInRange();

            lin.CityInformation();

            lin.displayNameAndScores();

            lin.displaySubjectNameAndAverage();

            lin.displayStudentsAndHighestAndLowestAverage();

            lin.displaySubjectAndHighestAndLowest();
        }
    }
}

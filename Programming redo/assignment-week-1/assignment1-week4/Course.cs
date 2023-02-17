using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_week4
{
    internal class Course
    {
        public string courseName;
        public int theoryGrade;
        public PracticalGrade practicalGrade;

        public bool Passed()
        {
            int failCount = 0;

            if ((theoryGrade>=55) && (practicalGrade == PracticalGrade.Good || practicalGrade == PracticalGrade.Sufficient))
            {
                return true;
            }
            else
            {
                failCount++;
                return false;
            }
        }

        public bool CumLaude()
        {
            if ((theoryGrade>=80) && (practicalGrade == PracticalGrade.Good))
            {
                return true;
            }
            else 
            {
                return false; 
            }
        }
    }
}

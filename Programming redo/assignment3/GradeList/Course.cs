using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeList
{
    internal class Course
    {
        public string CourseName;
        public int theoryGrade;
        public PracticalGrade practicalGrade;

        public bool Passed()
        {
            if ((theoryGrade>= 55) && (practicalGrade == PracticalGrade.Sufficient || practicalGrade == PracticalGrade.Good))
            {
                return true;
            }
            
            return false;
        }
        public bool CumLaude()
        {
            if ((theoryGrade >=80)&& (practicalGrade == PracticalGrade.Good))
            {
                return true;
            }
            return false;
        }
    }
    public enum PracticalGrade
    {
        None, Absent, Insufficient, Sufficient, Good
    }
}

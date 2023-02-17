using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3_week1
{
    public struct Person
    {
        public string FirstName;
        public string LastName;
        public string City;
        public int Age;
        public GenderType gender;
    }
    public enum GenderType
    {
        m,f
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public enum GenderType
    {
        m,f
    }
    public struct Person
    {
        public string FirstName;
        public string LastName;
        public string City;
        public int age;
        public GenderType Gender;
    }
}

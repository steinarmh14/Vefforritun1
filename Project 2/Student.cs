using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student
    {
        string name;
        int age;
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }

        public override string ToString()
        {
            return name + ", " + age;
        }

    }
}


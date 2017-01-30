using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;

namespace ConsoleApplication1
{
    class School
    {
        private List<Student> m_students = new List<Student>();
        string schoolName;

        public School(string school)
        {
            schoolName = school;
        }

        public void AddStudent(Student stud)
        {
            m_students.Add(stud);
        }

        public override string ToString()
        {
            string output = "School: " + schoolName + System.Environment.NewLine;
            output += "Number of students: " + m_students.Count() + System.Environment.NewLine;

            foreach (Student i in m_students)
            {
                output += "\t" + i.ToString() + System.Environment.NewLine;
            }

            return output;
        }
    }
}


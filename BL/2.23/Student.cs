using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL._2._23
{
    public class Student
    {
        public string Surname { get;  private set; }
        public int MidPoint { get; set; }
        public int Course { get; set; }

        public Student(string surname, int midPoint, int course)
        {
            Surname = surname;
            MidPoint = midPoint;
            Course = course;
        }

        virtual public double GetQuallity()
        {
            return 0.2 * MidPoint * Course;
        }

        public virtual string GetInformation()
        {
            return String.Format("{0}  Course: {1}  MidPoint: {2}  Quallity: {3} (BaseStudent)", Surname, Course, MidPoint, GetQuallity());
        }
    }
}

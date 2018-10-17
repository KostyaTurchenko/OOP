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

        public Student(string Surname, int MidPoint, int Course)
        {
            this.Surname = Surname;
            this.MidPoint = MidPoint;
            this.Course = Course;
        }

        virtual public double GetQuallity()
        {
            return 0.2 * MidPoint * Course;
        }

        virtual public string GetInformation()
        {
            return String.Format("{0}  Course: {1}  MidPoint: {2}  Quallity: {3} (BaseStudent)", Surname, Course, MidPoint, GetQuallity());
        }
    }
}

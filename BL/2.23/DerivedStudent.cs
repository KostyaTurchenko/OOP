using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL._2._23
{
    public class DerivedStudent : Student
    {
        public bool LearnigEn { get; set; }

        public DerivedStudent(string Surname, int MidPoint, int Course) 
            : base(Surname, MidPoint, Course)
        {

        }

        public override double GetQuallity()
        {
            if (LearnigEn)
                return 2 * base.GetQuallity();
            else
                return 0.9 * base.GetQuallity();
        }

        public override string GetInformation()
        {
            return String.Format("{0}  Course: {1}  MidPoint: {2}  Quallity: {3} (DerivedStudent)", Surname, Course, MidPoint, this.GetQuallity());
        }
    }
}

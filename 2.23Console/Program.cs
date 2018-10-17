using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BL._2._23;

namespace _2._23Console
{
    class Program
    {
        static int IntParser ()
        {
            int result;
            bool check = false;

            do
            {
                check = Int32.TryParse(Console.ReadLine(), out result);
                if (!check)
                    Console.WriteLine("invalid value entered try again");
            }
            while (!check);

            return result;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Surname:");
                string surname = Console.ReadLine();

                Console.WriteLine("Course:");
                int course = IntParser();

                Console.WriteLine("MidPoint:");
                int midpoint = IntParser();

                Console.WriteLine("1-BaseStudent; 2-DerivedStudent;");
                int ClassChoice = IntParser();
                if (ClassChoice == 2)
                {
                    DerivedStudent MyDerivedStudent = new DerivedStudent(surname, midpoint, course);
                    int ActionEng;
                    do
                    {
                        Console.WriteLine("1-known eng; 2 - no");

                        ActionEng = IntParser();
                        if (ActionEng == 1)
                            MyDerivedStudent.LearnigEn = true;
                        if(ActionEng == 2)
                            MyDerivedStudent.LearnigEn = false;
                    }
                    while (ActionEng != 1 && ActionEng != 2);
                    
                    Console.WriteLine(MyDerivedStudent.GetInformation()); 
                }
                else 
                {
                    Student MyBaseStudent = new Student(surname, midpoint, course);
                    Console.WriteLine(MyBaseStudent.GetInformation());
                }                    
            }
        }
    }
}

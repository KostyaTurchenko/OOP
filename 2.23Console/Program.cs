using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BL._2._23;

namespace _2._23Console
{
    class Program
    {
        static int IntParser (string message)
        {
            Console.WriteLine(message);
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("invalid value entered try again");
            }
            return result;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Surname:");
                string surname = Console.ReadLine();

                int course = IntParser("Course:");

                int midpoint = IntParser("MidPoint:");

                int classChoice = IntParser("1-BaseStudent; 2-DerivedStudent;");
                if (classChoice == 2)
                {                   
                    int actionEnglish;
                    Student MyDerivedStudent = null;

                    do
                    {
                        actionEnglish = IntParser("1-known english; 2 - no");
                        if (actionEnglish == 1)
                        {
                            MyDerivedStudent = new DerivedStudent(surname, midpoint, course, true);
                        }                            
                        if(actionEnglish == 2)
                        {
                            MyDerivedStudent = new DerivedStudent(surname, midpoint, course, false);
                        }                           
                    }
                    while (actionEnglish != 1 && actionEnglish != 2);
                    
                    Console.WriteLine(MyDerivedStudent.GetInformation()); 
                }
                else 
                {
                    Student myBaseStudent = new Student(surname, midpoint, course);
                    Console.WriteLine(myBaseStudent.GetInformation());
                }                    
            }
        }
    }
}

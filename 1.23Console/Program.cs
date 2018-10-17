using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BL;

namespace _1._23Console
{
    class Program
    {
        private void CreateCar (int TypeOfCar)
        {
                
        }
        static void Main(string[] args)
        {
            ParkOfCars MyPark = new ParkOfCars();

            while (true)
            {
                Console.WriteLine("1 - Add car, 2 - GetCost, 3 - Sort, 4 = FindCar");
                int Action = Convert.ToInt32(Console.ReadLine());

                switch (Action)
                {
                    case 1:
                        Console.WriteLine("Name: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Number: ");
                        string number = Console.ReadLine();

                        Console.WriteLine("Price: ");
                        int price = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("FuelConsumption: ");
                        int fuelconsumption = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Speed: ");
                        int speed = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("1 - VIP, 2 - Good, 3 - Simple");
                        int TypCar = Convert.ToInt32(Console.ReadLine());
                        switch (TypCar)
                        {
                            case 1:
                                MyPark.AddVIPCar(name, number, price, fuelconsumption, speed);
                                break;
                            case 2:
                                MyPark.AddSimpleCar(name, number, price, fuelconsumption, speed);
                                break;
                            case 3:
                                MyPark.AddSimpleCar(name, number, price, fuelconsumption, speed);
                                break;
                            default:
                                Console.WriteLine("adding error");
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine(MyPark.GetCost());
                        break;
                    case 3:
                        Console.WriteLine(MyPark.GetSortedCars());
                        break;
                    case 4:
                        Console.WriteLine("min");
                        int min = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("max");
                        int max = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(MyPark.GetSpeedCar(min, max));
                        break;
                }
            }

        }
    }
}

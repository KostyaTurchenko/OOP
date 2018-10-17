using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BL;

namespace _1._23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MyWindow : Window
    {
        ParkOfCars MyPark;
        public MyWindow()
        {
            InitializeComponent();
            MyPark = new ParkOfCars();
            MyPark.AddSimpleCar("ladasedan", "м371ак", 400000, 7, 175);
            MyPark.AddGoodCar("subaru_forester", "н136ор", 1800000, 8, 198);
            MyPark.AddVIPCar("mers_cls", "е777кх", 5000000, 5, 250);

            Cost_label.Content = null;
            Cost_label.Content = MyPark.GetCost();
        }

        private void Sort_button_Click(object sender, RoutedEventArgs e)
        {
            Sort_label.Content = MyPark.GetSortedCars();
        }

        private void get_cars_button_Click(object sender, RoutedEventArgs e)
        {
            int fist = Int32.Parse(first_text.Text);
            int sec = Int32.Parse(second_text.Text);
            Sort_label.Content = null;
            Sort_label.Content = MyPark.GetSpeedCar(fist, sec);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string Name = NameTextBox.Text;
            string Number = NumberTextBox.Text;
            int Price = Convert.ToInt32(PriceTextBox.Text);
            int Fuel = Convert.ToInt32(FuelTextBox.Text);
            int Speed = Convert.ToInt32(SpeedTextBox.Text);
            if (SimpleCarRBut.IsChecked == true)
                MyPark.AddSimpleCar(Name, Number, Price, Fuel, Speed);
            else if (GoodCarRBut.IsChecked == true)
                MyPark.AddGoodCar(Name, Number, Price, Fuel, Speed);
            else
                MyPark.AddVIPCar(Name, Number, Price, Fuel, Speed);
        }

        private void Show_price_Click(object sender, RoutedEventArgs e)
        {
            Cost_label.Content = MyPark.GetCost();
        }
    }
}

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
using BL._3._23;

namespace _3._23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MyWindow : Window
    {
        WorkWithConstructionEquipment WorkInstance = new WorkWithConstructionEquipment();

        public MyWindow()
        {
            InitializeComponent();
        }

        private void buttonShowInformation_Click(object sender, RoutedEventArgs e)
        {
            labelInformation.Content = WorkInstance.GetInformation();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string name = Convert.ToString(nameTextBox.Text);

            int year;
            while (!int.TryParse(yearTextBox.Text, out year))
            {
                throw new Exception();
            }

            int cost;
            while (!int.TryParse(costTextBox.Text, out cost))
            {
                throw new Exception();
            }

            int fuel;
            while (!int.TryParse(fuelConsumptionTextBox.Text, out fuel))
            {
                throw new Exception();
            }

            int capacity;
            while (!int.TryParse(capacityTextBox.Text, out capacity))
            {
                throw new Exception();
            }

            int power;
            while (!int.TryParse(powerTextBox.Text, out power))
            {
                throw new Exception();
            }

            WorkInstance.AddEquipment(new Excavator(name, year, cost, fuel, capacity, power));
        }
    }
}

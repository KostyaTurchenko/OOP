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
using BL._2._23;

namespace _2._23
{
    /// <summary>
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        public StudentWindow()
        {
            InitializeComponent();            
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            string surname = SurnameTextBox.Text;

            int course;
            while (!int.TryParse(CourseTextBox.Text, out course))
            {
                throw new Exception("Format Exception");
            }

            int midPoint;
            while (!int.TryParse(MidPointTextBox.Text, out midPoint))
            {
                throw new Exception("Format Exception");
            }

            if (DerivedStudentRBut.IsChecked == true)
            {
                Student myStudent = new DerivedStudent(surname, midPoint, course, (bool)KnownEng.IsChecked);                               
                ShowingLabel.Content = myStudent.GetInformation();
            }
            else
            {
                Student myBaseStudent = new Student(surname, midPoint, course);
                ShowingLabel.Content = myBaseStudent.GetInformation();
            }

        }
    }
}

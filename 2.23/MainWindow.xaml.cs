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
        DerivedStudent MyStudent;
        public StudentWindow()
        {
            InitializeComponent();            
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            string Surname = SurnameTextBox.Text;
            int Course = Convert.ToInt32(CourseTextBox.Text);
            int MidPoint = Convert.ToInt32(MidPointTextBox.Text);           
            
            if (DerivedStudentRBut.IsChecked == true)
            {
                MyStudent = new DerivedStudent(Surname, MidPoint, Course);

                if (KnownEng.IsChecked == true)
                    MyStudent.LearnigEn = true;
                else
                    MyStudent.LearnigEn = false;

                ShowingLabel.Content = MyStudent.GetInformation();
            }
            else
            {
                Student MyBaseStudent = new Student(Surname, MidPoint, Course);
                ShowingLabel.Content = MyBaseStudent.GetInformation();
            }

        }
    }
}

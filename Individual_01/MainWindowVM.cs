using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Media3D;

namespace Individual_01
{
    public partial class MainWindowVM:ObservableObject
    {
        public static ObservableCollection<Student> Students { get; set; }
        public static int index = 10;
        public static Student SelectedStudent { get; set; }

        public MainWindowVM()
        {
            Students = new ObservableCollection<Student>();
            Students.Add(new Student(1, "Emily", "Johnson", "05/12/2002", "123 Main St, Anytown, USA", "2.png", 3.5));
            Students.Add(new Student(2, "Jacob", "Smith", "09/22/2000", "456 Elm St, Anytown, USA", "3.png", 3.2));
            Students.Add(new Student(3, "Olivia", "Garcia", "11/17/2001", "789 Oak St, Anytown, USA", "4.png", 3.9));
            Students.Add(new Student(4, "Michael", "Davis", "02/14/2000", "321 Pine St, Anytown, USA", "5.png", 3.7));
            Students.Add(new Student(5, "Isabella", "Wilson", "08/21/2002", "654 Maple St, Anytown, USA", "6.png", 3.4));
            Students.Add(new Student(5, "Ethan", "Anderson", "06/09/2000", "987 Cedar St, Anytown, USA", "7.png", 3.6));
            Students.Add(new Student(7, "Sophia", "Martinez", "04/30/2001", "246 Walnut St, Anytown, USA", "8.png", 3.8));
            Students.Add(new Student(8, "Daniel", "Hernandez"  , "01/02/2000", "135 Oak St, Anytown, USA", "9.png", 3.3));
            Students.Add(new Student(9, "Mia", "Moore", "07/27/2002", "864 Pine St, Anytown, USA", "10.png", 3.9));
            Students.Add(new Student(10, "Alexander", "Taylor", "03/14/2000", "975 Elm St, Anytown, USA", "1.png", 3.5));
        }

        [RelayCommand]
        public void openAddUserWindow()
        {
            var window = new AddStudentWindow();
            window.Show();
        }

        

        private RelayCommand editStudentWindowCommand1;
        public ICommand editStudentWindowCommand => editStudentWindowCommand1 ??= new RelayCommand(editStudentWindow1);
        public void editStudentWindow1()
        {
            if (SelectedStudent != null)
            {
                var window = new EditStudentWindow(SelectedStudent);
                window.Show();
            }
            else
            {
                MessageBox.Show("Select a Student");
            }

        }


        

        private RelayCommand removeStudentCommand1;
        public ICommand removeStudentCommand => removeStudentCommand1 ??= new RelayCommand(removeStudent1);

        public void removeStudent1()
        {
            if (SelectedStudent != null)
            {
                Students.Remove(SelectedStudent);
                MessageBox.Show("Student Removed");
            }
            else
            {
                MessageBox.Show("Select a Student");
            }
        }
    }
}

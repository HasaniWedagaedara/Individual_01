using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Individual_01
{
    public partial class EditStudentWindowVM:ObservableObject
    {
        public Student Student { get; set; }
        public bool Male1 { get; set; }
        public bool Male2 { get; set; }
        public bool Male3 { get; set; }
        public bool Female1 { get; set; }
        public bool Female2 { get; set; }
        public bool Female3 { get; set; }
        public EditStudentWindowVM(Student s)
        {
            Student = s;
            if (s.Image == "1.png")
                Male1 = true;
            else if(s.Image == "2.png")
                Male2 = true;
            else if (s.Image == "3.png")
                Male3 = true;
            else if (s.Image == "4.png")
                Female1 = true;
            else if (s.Image == "6.png")
                Female2 = true;
            else if (s.Image == "7.png")
                Female2 = true;
        }

        public EditStudentWindowVM()
        {
            
        }

        

        private RelayCommand changeStudentCommand1;
        public ICommand changeStudentCommand => changeStudentCommand1 ??= new RelayCommand(changeStudent1);
        public void changeStudent1()
        {
            if (Student.FirstName != null && Student.LastName != null && Student.Address != null && Student.Birthday != null && Student.GPA != null)
            {
                if (Male1 == false && Male2 == false && Male3 == false && Female1 == false && Female2 == false && Female3 == false)
                {
                    MessageBox.Show("No Avatar Selected");
                }
                else
                {
                    if (Male1 == true)
                        Student.Image = "1.png";
                    else if (Male2 == true)
                        Student.Image = "2.png";
                    else if (Male3 == true)
                        Student.Image = "3.png";
                    else if (Female1 == true)
                        Student.Image = "4.png";
                    else if (Female2 == true)
                        Student.Image = "6.png";
                    else if (Female3 == true)
                        Student.Image = "7.png";
                }
                if (Student.GPA > 4 && Student.GPA < 0)
                    MessageBox.Show("Invalid GPA");
                else
                {
                    int index = MainWindowVM.Students.IndexOf(MainWindowVM.Students.FirstOrDefault(s => s.Id == Student.Id));
                    MainWindowVM.Students.Remove(MainWindowVM.Students.FirstOrDefault(s => s.Id == Student.Id));
                    MainWindowVM.Students[index] = Student;
                    MessageBox.Show("Student Updated");
                }

            }
            else
            {
                MessageBox.Show("Enter All Details");
            }
        }
    }
}

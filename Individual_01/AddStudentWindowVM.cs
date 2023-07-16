using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Individual_01
{
    public partial class AddStudentWindowVM:ObservableObject
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Addr { get; set; }
        public string BDay { get; set; }
        public double Gpa { get; set; }
        public bool Male1 { get; set; }
        public bool Male2 { get; set; }
        public bool Male3 { get; set; }
        public bool Female1 { get; set; }
        public bool Female2 { get; set; }
        public bool Female3 { get; set; }
        public string Img { get; set; }
        public AddStudentWindowVM()
        {
            Male1 = false;
            Male2 = false;
            Male3 = false;
            Female1 = false;
            Female2 = false;
            Female3 = false;
        }

        [RelayCommand]
        public void addStudent()
        {
            if(FName!=null && LName!=null && Addr!=null && BDay!=null && Gpa != null)
            {
                if(Male1==false && Male2==false && Male3==false && Female1==false && Female2==false && Female3 == false)
                {
                    MessageBox.Show("No Avatar Selected");
                }
                else
                {
                    if (Male1 == true)
                        Img = "1.png";
                    else if (Male2 == true)
                        Img = "2.png";
                    else if (Male3 == true)
                        Img = "3.png";
                    else if (Female1 == true)
                        Img = "4.png";
                    else if (Female2 == true)
                        Img = "6.png";
                    else if (Female3 == true)
                        Img = "7.png";
                }
                if (Gpa > 4 && Gpa < 0)
                    MessageBox.Show("Invalid GPA");
                else
                {

                    Student std = new Student(++MainWindowVM.index, FName, LName, BDay, Addr, Img, Gpa);
                    MainWindowVM.Students.Add(std);
                    MessageBox.Show("Student Added");
                }

            }
            else
            {
                MessageBox.Show("Enter All Details");
            }
        }
    }
}

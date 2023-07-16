using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_01
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName {
            get { return $"{FirstName} {LastName}"; }
        }
        public int Age { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public double GPA { get; set; }
        public string ImageURL {
            get { return $"/Images/{Image}"; }
        }

        public Student(int id, string firstName, string lastName, string birthday, string address, string image, double gPA)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            Address = address;
            Image = image;
            GPA = gPA;
        }
    }
}

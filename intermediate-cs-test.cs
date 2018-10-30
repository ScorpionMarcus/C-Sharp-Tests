using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Arrays
            var numbers = new int[] { 45, 22, 87, 56, 92 };

            // Lists
            List<int> integers = new List<int>();
            integers.Add(1);
            integers.Add(2);
            integers.Add(3);

            // An Array has a set number of items while a List is dynamic (you can add and remove items)

            // Switch Statements
            Console.WriteLine("How many years of experience do you have?");
            var years = int.Parse(Console.ReadLine());

            switch (years)
            {
                case 0:
                    Console.WriteLine("Inexperienced");
                    break;
                case 1:
                    Console.WriteLine("Junior");
                    break;;
                case 2:
                    Console.WriteLine("Advanced");
                    break;
                default:
                    Console.WriteLine("Senior");
                    break;
            }

            // Classes and Constructors (see class "Student" below)
            var newStudent = new Student();
            newStudent.Name = "John";

            // Properties (see class "Student" below)
            Console.WriteLine("Student Phone Number: ");
            newStudent.Phone = int.Parse(Console.ReadLine());

            // Try/Catch Exceptions
            try
            {
                int x = 0;
                int y = 7 / x;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();

        }
    }

    class Student
    {
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        private int phone;

        // Property
        public int Phone
        {
            set { phone = value; }
        }

        // the constructor executes as soon as the object is created or constructed, it also allows us to pass parameters
        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }

        // if you create an instance of the constructor without parameters, you will need to create a second empty constructor
        public Student()
        {

        }
    }
}
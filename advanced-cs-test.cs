using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        // Method Overloading
        static public string Ask(string question)
        {
            
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static public string Ask(int question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        // Events (see "Stats" class below)
        static public event Action Posted;

        static void Main(string[] args) {

            var stats = new Stats();
            Posted();

            // Abstract Classes (see the "Shape" abstract class, "Square" class, and "Triangle" class below)
            var square = new Square() { Width = 2 };
            var triangle = new Triangle() { Base = 2, Height = 5 };

            square.Display();
            triangle.Display();

            // String Interpolation
            string name = "John";
            string ama = "Cool Guy";
            string stringInt = "String Interpolation";
            Console.WriteLine($"My name is {name}. I am a {ama} and I'm good at {stringInt}!");
        }
    }

    class Stats
    {
        public void Start()
        {
            Program.Posted += HasPosted;
        }

        void HasPosted()
        {
            Console.WriteLine("Survey posted, run stats");
        }
    }

    abstract class Shape
    {
        public abstract int GetArea();
        public void Display()
        {
            Console.WriteLine("The area is {0}", GetArea());
        }
    }

    class Square: Shape
    {
        public int Width;

        public override int GetArea()
        {
            return Width * Width;
        }
    }

    class Triangle: Shape
    {
        public int Base;
        public int Height;

        public override int GetArea()
        {
            return (Base * Height) / 2;
        }
    }

    // Auto-implemented Properties
    class Member
    {
        public string Name { get; set; }
    }
}
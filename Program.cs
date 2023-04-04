using System;
using Interface;
using Struct;

namespace NestedClass
{
    class Program
    {
        static void Main(string[] args)
        {

            // object of inner class
            Car.Engine engineObj = new Car.Engine();
            engineObj.displayCar();

            // object of derived class
            Laptop obj = new Laptop();
            obj.display();

            //object of Rectangle class
            Interface.Rectangle r1 = new Interface.Rectangle();

            r1.calculateArea(100, 200);
            r1.getColor();

            IFile file1 = new F();
            F file2 = new F();

            file1.ReadFile();
            file1.WriteFile("content");
            //file1.Search("text t")//compile-time error 

            file2.Search("text to be searched");
            //file2.ReadFile(); //compile-time error 
            //file2.WriteFile("content"); //compile-time error 

            // calls constructor of struct
            Employee emp = new Employee(1, "Brian");

            Console.WriteLine("Employee Name: " + emp.name);
            Console.WriteLine("Employee Id: " + emp.id);

            Console.ReadLine();
        }
    }

    //Access Outer Class Members Inside Inner Class
    // outer class
    public class Car
    {

        public string brand = "Bugatti";

        // nested  class
        public class Engine
        {
            public void displayCar()
            {
                // object of outer class
                Car sportsCar = new Car();
                Console.WriteLine("Brand: " + sportsCar.brand);
            }
        }
    }

    //Inheriting Outer Class
    // outer class
    class Computer
    {

        public void display()
        {
            Console.WriteLine("Method of Computer class");
        }

        // nested class
        public class CPU
        {

        }
    }

    class Laptop : Computer
    {

    }
}

 //Implementing an Interface
namespace Interface
{

    interface IPolygon
    {
        // method without body
        void calculateArea(int l, int b);

    }
    interface IColor
    {
        void getColor();
    }

    //Implements two interface
    class Rectangle : IPolygon, IColor
    {

        // implementation of IPolygon interface
        public void calculateArea(int l, int b)
        {

            int area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }

        // implementation of IColor interface
        public void getColor()
        {
            Console.WriteLine("Red Rectangle");
        }
    }

    //Example: Explicit interface Implementation
    interface IFile
    {
        void ReadFile();
        void WriteFile(string text);
    }

    class F : IFile
    {
        void IFile.ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        void IFile.WriteFile(string text)
        {
            Console.WriteLine("Writing to file");
        }

        public void Search(string text)
        {
            Console.WriteLine("Searching in file");
        }
    }


}

//Struct
namespace Struct
{
    // defining struct
    struct Employee
    {
        public int id;
        public string name;

        // parameterized constructor
        public Employee(int employeeID, string employeeName)
        {
            id = employeeID;
            name = employeeName;
        }
    }
}





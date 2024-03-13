﻿using System.ComponentModel.DataAnnotations;

namespace programming010.oop;
static class Program
{
    class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    class Customer : Account
    {
        public string CustomerName { get; set; }    
    }

    class Driver : Account
    {
        public string DriverLicenseNumber { get; set; }
    }

    class Enemy
    {
        public int Speed { get; set; }

        public void Walk()
        {
            Console.WriteLine("walking...");
        }
    }

    class FlyingEnemy : Enemy
    {
        public void Fly()
        {
            Console.WriteLine("flying...");
            Console.WriteLine("Current speed is: " + Speed);
        }
    }

    class MainCharacter : Enemy
    {
        
    }

    static void Main(string[] args)
    {
        //method overloading
        //Console.WriteLine(Sum(1, 2));
        //Console.WriteLine(Sum(1, 2.0));

        //Console.WriteLine(Sum(1,'2'));
        //code smells

        //Print();
        //Print("Hello from another world");

        //Console.WriteLine(Sum(x: 1, y: 2));

        //Print();
        //Generics

        //int[] arr = { 1, 2, 3, 4, 5 };
        //double[] arr2 = { 1.2, 3.4, 5.2 };
        //string[] arr3 = { "a", "b", "c" };

        //FindMax(arr);
        //FindMax(arr2);

        //Console.WriteLine(FindMax(arr3));
        //int res = FindMax(1, 2, 3);
        //Console.WriteLine(res);

        //Polymorphism (Compile time)
        //Method overloading
        //Generics (classes, methods)
        //Params

        //Runtime polymorphism
        //virtual methods/override

        //Inheritence
        //Created for code reuse

        FlyingEnemy enemy = new FlyingEnemy();

        enemy.Walk();
        enemy.Fly();

        Customer customer = new Customer();
        customer.CustomerName = "Mahammad";
        customer.Username = "mahammmad";
        customer.Password = "12345";

    }

    static T FindMax<T>(params T[] arr) where T : IComparable<T>
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        T max = default(T);
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].CompareTo(max) > 0)
            {
                max = arr[i];
            }
        }

        return max;
    }

    static bool Equals<T>(T a, T b)
    {
        return a.Equals(b);
    }

    static void Print(string message = "Hello" + "World")
    {
        Console.WriteLine(message);
    }

    static int Sum(int x, int y, int z = 15 / 3)
    {
        return x + y + z;
    }

    static int Sum(int x, int y)
    {
        return x + y;
    }

    //static void Print(string message)
    //{
    //    Console.WriteLine(message);
    //}
    //static void Print()
    //{
    //    Print("Hello World");
    //}


    ////method signature
    //static int Sum(int x, int y)
    //{
    //    Console.WriteLine("int");
    //    return x + y;
    //}

    //static float Sum(float x, float y)
    //{
    //    Console.WriteLine("float");
    //    return x + y;
    //}

    //static float Sum(float x, float y, float z)
    //{
    //    Console.WriteLine("float3");
    //    return x + y + z;
    //}

    //static double Sum(double x, double y) 
    //{
    //    Console.WriteLine("double");
    //    return x + y;
    //}

    //static double Sum(int x, double y)
    //{
    //    Console.WriteLine("int double");
    //    return x + y;
    //}

    //static double Sum(int x, char y)
    //{
    //    return x + y;
    //}
}
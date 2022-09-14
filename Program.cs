using System;

namespace WhatTheFuckMate
{

    class Bruh
    {

        Bruh(string urmom)
        {
            Console.WriteLine($"urmom: {urmom}");
        }

        Bruh(int weight)
        {
            Console.WriteLine($"weight: {weight}");
        
        }
       
        static void Main(string[] args) {

            Bruh bruh = new Bruh("Yo mama so fat");

            Console.WriteLine();

            Bruh bruh2 = new Bruh(700);

            Console.ReadLine();


        }
    }
}



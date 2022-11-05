using System;
using System.Xml;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */


            Console.WriteLine("*******Birds********");
            var egle = new Bird();
            egle.Name = "Egle";
            egle.LifeSpean = 30;
            egle.color = "White";
            egle.lifeEnviroment();
            egle.BirdMesure(36);
            egle.food = "Mammals";
            egle.Type = "Bald";

           
            

            
            
            Console.WriteLine($"The {egle.Name} can live around" +
                $" {egle.LifeSpean} years and general eats" +
                $" {egle.food}");

            Console.WriteLine();

            /*Create an object of your Reptile class
             *  *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
            */

            Console.WriteLine("*******Reptiles********");

            var iguana = new Reptile(); 
            iguana.Name = "Iguanas";
            iguana.LifeSpean = 15;
            iguana.Brethe = "Lugs";
            iguana.color = "Green";
            iguana.legs = 4;
            iguana.food = "Flowers";
            iguana.Type = "Lesser";
            iguana.bloodType = "Cool Blood";



            Console.WriteLine($"{iguana.Name}" +
                $" type {iguana.Type} " +
                $"are repitiles and live around" +
                $" {iguana.LifeSpean} years and  normaly have {iguana.legs} legs " +
                $"and likes to eats {iguana.food} {iguana.Name} have " +
                $"{iguana.bloodType}");

        }
    }
}

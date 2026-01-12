using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            var suvOne = new Suv();
            suvOne.Make = "GMC";
            suvOne.Model = "Yukon";
            suvOne.Year = 2005;
            suvOne.Color = "Red";
            suvOne.Logo = "GMC";
            suvOne.NameOfCompany = "General Motors";
            suvOne.Location = "Arlington, Texas";
            suvOne.NumberOfRows = 3;
            suvOne.NumberOfSeats = 7;
            
            var carOne = new Car();
            carOne.Make = "Ford";
            carOne.Model = "Mustang";
            carOne.Year = 2006;
            carOne.Logo = "Ford";
            carOne.Color = "Blue";
            carOne.NameOfCompany = "Ford Motors";
            carOne.Location = " Flat Rock, Michigan";
            carOne.HasTrunk = true;
            carOne.NumberOfDoors = 2;
            
            var truckOne = new Truck();
            truckOne.Make = "Chevrolet";
            truckOne.Model = "Silverado";
            truckOne.Year = 2007;
            truckOne.Color = "Green";
            truckOne.Logo = "Chevrolet";
            truckOne.NameOfCompany = "General Motors";
            truckOne.Location = "Flint, Michigan ";
            truckOne.HasFifthWheelHitch = false;
            truckOne.Is4WheelDrive = true;
            
            var parkingLot = new List<IManufacturer>(){suvOne, truckOne,carOne};

            foreach (var item in parkingLot)
            {
                Console.WriteLine($"Vehicle: {item.Make}, Name: {item.Model}, Year: {item.Year}, Color: {item.Color}, Logo: {item.Logo}, Made in: {item.Location}");
            }


            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}

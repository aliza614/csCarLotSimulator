﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot
    //*************BONUS X 2*************//

    //Create a CarLot class
    //It should have at least one property: a List of cars
    //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
    //At the end iterate through the list printing each of car's Year, Make, and Model to the console
    {
        public static int numberOfCars=0;
        public List<Car> carList;


        public CarLot()
        {
            carList = new List<Car>();
        }

        public void AddCar(Car carItem)
        {
            carList.Add(carItem);
            numberOfCars++;
            Console.WriteLine($"Car number {numberOfCars} is a {carItem.Year} {carItem.Make} {carItem.Model}.");

        }
    }
}

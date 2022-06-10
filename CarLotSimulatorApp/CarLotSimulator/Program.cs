using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = new string("Hi");
            var car = new Car();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            //all above DONE
            var carLot =new CarLot();
            //Now that the Car class is created we can instanciate 3 new cars
            var car1 = new Car();
            carLot.carList.Add(car1);
            //Set the properties for each of the cars 
            //Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            car1.Year = "2000";
            car1.Make = "Honda";
            car1.Model = "Accord";
            car1.EngineNoise = "whir";
            car1.HonkNoise = "beep";
            car1.IsDriveable = true;

            var car2 = new Car()
            {
                Year = "2001",
                Make = "Hyundai",
                Model = "Accent",
                EngineNoise = "hiss",
                HonkNoise = "honk",
                IsDriveable = true
            };
            carLot.carList.Add(car2);
            Car car3 = new Car(
                "2002",
                "Ford",
                "Taurus",
                "hum",
                "eeehh",
                true);
            carLot.carList.Add(car3);
            //Call each of the methods for each car
            //MakeEngineNoise(), MakeHonkNoise()
            car1.MakeEngineNoise("screetch");
            car1.MakeHonkNoise("aaahh");
            car2.MakeEngineNoise("screetch");
            car2.MakeHonkNoise("aaahh");
            car3.MakeEngineNoise("screetch");
            car3.MakeHonkNoise("aaahh");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car DONE

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (var carItem in carLot.carList.ToArray())
            {
                Console.WriteLine($"The car is a {carItem.Year} {carItem.Make} {carItem.Model}.");
            }
        }


    }
}

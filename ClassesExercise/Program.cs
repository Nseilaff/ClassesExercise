using ClassesExercise;


Car natesCar = new Car()
{
    Make = "Chevy",
    Model = "Silverado",
    Year = 2021

};

Console.WriteLine($"Nates new vehicle is {natesCar.Year} {natesCar.Make} {natesCar.Model} ");

var carLot = new List<Car>();
namespace Opdracht;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
  static void Main()
  {
    Driver Emir = new("Emir", 17, "12345");
    Driver Ensar = new("Ensar", 18, "54321");
    Human Yassine = new("Yassine", 17);
    Human Bert = new("Bert", 69);
    Human Mustapha = new("Mustapha", 18);


    List<Car> cars = new()
    {
          new("250", "Mercedes", Emir),
          new("XC40", "Volvo", Ensar),
          new("Golf", "VW", Ensar)
          {
             Passengers = { Yassine, Bert, Mustapha }
          }
    };

    Console.WriteLine(cars[0].Brand);

    foreach (var car in cars)
    {
      Console.WriteLine(car.Brand);
    }

    var volvos = cars.First(car => car.Brand == "Volvo");  // Linq = Language Integrated Query
   

    string json = JsonSerializer.Serialize(cars);
    File.WriteAllText("cars.json", json);


  }
}

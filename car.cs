namespace Opdracht;

public class Car
{
  public string Model { get; set; }
  public string Brand { get; set; }
  public int Year { get; set; }
  public Driver Driver { get; set; }
  public List<Human> Passengers { get; set; }

  public Car(string model, string brand, Driver driver)
  {
    Model = model;
    Brand = brand;
    Driver = driver;
    Passengers = new List<Human>();
  }
}
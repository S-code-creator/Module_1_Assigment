//task 2
class Car
{
    
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Mileage { get; set; }

    // task 2
    public void ShowCarInfo()
    {
        Console.WriteLine($"Car Info: Brand - {Brand}, Model - {Model}, Year - {Year}, Mileage - {Mileage}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Object 1
        Car car1 = new Car
        {
            Brand = "Toyota",
            Model = "Corolla",
            Year = 2020,
            Mileage = 80
        };

        // Object 2
        Car car2 = new Car
        {
            Brand = "Tesla",
            Model = "Model 3",
            Year = 2022,
            Mileage = 120
        };

       
        car1.ShowCarInfo();
        car2.ShowCarInfo();
    }
}



//Task 1
class Car
{
   
   //step 1
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Mileage { get; set; }

    // step 2
    public void Drive(int kilometers)
    {
        Mileage += kilometers;
        Console.WriteLine($"Car {Brand} {Model}  driven {kilometers} km. Total mileage: {Mileage} km.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Car car1 = new Car
        {
            Brand = "BMW",
            Model = "BMW i7",
            Year = 2022,
            Mileage = 625
        };

        car1.Drive(50);
        
    }
}

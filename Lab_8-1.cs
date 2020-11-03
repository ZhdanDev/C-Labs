using System;
using System.Collections.Generic;
using System.Linq;
//Гараж шейха
namespace Lab_7
{
 
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
    }

    public class Garage
    {
        public List<Car> cars = new List<Car>();

        public void Buy(string _Brand, string _Model, string _Color, int _Speed)
        {
           
            cars.Add(new Car { Brand = _Brand, Model = _Model, Color = _Color, Speed = _Speed });
        }
         
        public void RemoveCar()
        {
            int i = 0;
            int numbertoremove;
            foreach (var item in cars)
            {
                
                Console.WriteLine($"{i}. Brand {item.Brand} , Model {item.Model}");
                i++;
            }

            Console.Write("Enter number of car to remove :");
            numbertoremove = Convert.ToInt32(Console.ReadLine());
            cars.RemoveAt(numbertoremove);
        }   

        public void DisplayCars(List<Car> cars)
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            foreach (var car in cars)
            {
              
                Console.WriteLine($"Brand {car.Brand} , Model {car.Model}, Color {car.Color}, Speed {car.Speed}");
                
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }

        public List<Car> GetCarsByBrand(string brand) => cars.Where(d => d.Brand == brand).ToList();
        public List<Car> GetCarsByModel(string model) => cars.Where(d => d.Model == model).ToList();
        public List<Car> GetCarsByColor(string color) => cars.Where(d => d.Color == color).ToList();
        public List<Car> GetCarsBySpeed(int speed) => cars.Where(d => d.Speed == speed).ToList();
    }
    
    
    
    class Program
    {   

        static void Main(string[] args)
        {

            Garage g = new Garage();
            g.Buy("Subaru", "x750", "red", 700);
            g.Buy("Subaru", "x751", "blue", 800);
            g.Buy("Subaru", "x752", "red", 700);
            g.Buy("BMW", "x753", "yellow", 900);
            g.Buy("Audi", "x754", "purple", 800);

            g.DisplayCars(g.cars);

            g.DisplayCars(g.GetCarsByBrand("Subaru"));
            g.DisplayCars(g.GetCarsByModel("x752"));
            g.DisplayCars(g.GetCarsByColor("red"));
            g.DisplayCars(g.GetCarsBySpeed(700));


        }
    }
}

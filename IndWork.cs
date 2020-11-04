using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace IndWork
{

    public class HeadphoneManager
    {
        private List<Headphone> headphones = new List<Headphone>();
        public HeadphoneManager()
        {
            headphones = new List<Headphone>
            {
                new Headphone(20000,"2000",50),
                new Headphone(20001,"2001",51),
                new Headphone(20002,"2002",52),
                new Headphone(20003,"2003",53),
                new Headphone(20004,"2004",54)
            };
        }
        public List<Headphone> GetAllCognacs() => headphones;
        public List<Headphone> GetByYear(string year) => headphones.Where(d => d.year == year).ToList();
        public List<Headphone> GetByPrice(double price) => headphones.Where(d => d.price == price).ToList();
        public List<Headphone> GetByVolume(double volume) => headphones.Where(d => d.volume == volume).ToList();
    }
}


public class Headphone
{
    public double price { get; set; }
    public string year { get; set; }
    public List<string> colors = new List<string>();
    public double volume { get; set; }



    public Headphone(double price, string year, double volume)
    {
        this.price = price;
        this.year = year;
        this.volume = volume;
        colors.Add("red");
        colors.Add("green");
        colors.Add("blue");
    }

    public override string ToString()
    {
        return $"Price: {price}, Endurance: {year}, CreatedBy: {volume}, Volume: {volume}";
    }
}


class Program
{
    static void Main(string[] args)
    {

    }
}


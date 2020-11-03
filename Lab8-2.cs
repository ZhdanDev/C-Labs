using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_7
{
//Phone Evolution
    public class DiskPhone
    {
        public string Number { get; set; }
        public List<string> AvailableSymbols = new List<string>
        {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
        };


    }

    public class ButtonPhone : DiskPhone
    {
        public ButtonPhone()
        {
            AvailableSymbols.AddRange(new List<string>
            {
                "Enter",
                "Cancel",
                "*",
                "#"
            });
        }
    }
    public class BlackWhitePhone : ButtonPhone
    {
        public string Resolution { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public BlackWhitePhone()
        {
            AvailableSymbols.AddRange(new List<string>
            {
                "Reset"
            });
        }
    }

    public class СolorPhone : BlackWhitePhone
    {
        public int NumOfColors { get; set; }
        public bool DualSim { get; set; }
        public string SecondNumber { get; set; }
    }

    public class SmartPhone : СolorPhone
    {
        public bool TouchPad { get; set; }
        public int CountOfTouchs { get; set; }
        public int NumOfCameras { get; set; }
    }

    class Program
    {   

        static void Main(string[] args)
        {

           

        }
    }
}

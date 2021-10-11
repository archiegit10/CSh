using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThree
{
    class Car
    {
        public string manufacturer;
        public string model;
        public string dateManufactured;

        public string GetInfo()
        {
            return $"Manufacturer: {manufacturer} Model: {model} Date: {dateManufactured}";
        }
        //empty constructor
        public Car(string manufacturer, string model) : this(manufacturer, model,"2000")
        {
            Console.WriteLine($"{manufacturer} Model: {model}, Date: {dateManufactured}");
        }
        // constructor overload
        public Car(string manufacturer, string model, string dateManufactured)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.dateManufactured = dateManufactured;

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_enum
{
     public class Car
    {

        private static int _counter ;
        public int Id { get; set; }

        public string Brand { get; set; }
        public string Model { get; set; }

        public Type Type { get; set; }
        public Car(string brand, string model,Type type)
        {
            Id = ++_counter;
            Brand = brand;
            Model = model;
            Type = type;
        }
        public override string ToString()
        {
            return $"{Id}-{Brand}-{Model}-{Type}";
        }
    }
}

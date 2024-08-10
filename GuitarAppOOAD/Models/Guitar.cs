using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppOOAD.Models
{
    public class Guitar
    {
        public string SerialNumber { get; set; }
        public double GuitarPrice { get; set; }
        public GuitarSpecifications Specifications { get; set; }

        public Guitar(string serialNumber, double guitarPrice, GuitarSpecifications specifications)
        {
            SerialNumber = serialNumber;
            GuitarPrice = guitarPrice;
            Specifications = specifications;
        }

        public override string ToString()
        {
            return $"Serial Number of Guitar: {SerialNumber} \n" +
                $"Price of Guitar: {GuitarPrice} \n" +
                $"Number of Strings: {Specifications.NumberOfStrings}\n" +
                $"Guitar Builder: {Specifications.GuitarBuilder} \n" +
                $"Guitar Model: {Specifications.GuitarModel} \n" +
                $"Guitar Type: {Specifications.GuitarType} \n" +
                $"Guitar's Backwood: {Specifications.BackWood} \n" +
                $"Guitar's Topwood: {Specifications.TopWood}";
        }
    }
}

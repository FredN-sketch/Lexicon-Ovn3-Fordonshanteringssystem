using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Ovn3_Fordonshanteringssystem.Vehicles
{
    public abstract class Vehicle
    {
        private string brand;
        private string model;
        private int year;
        private double weight;

        public string Brand
        {
            get { return brand; }
            set
            {
                if (value.Length >= 2 && value.Length <= 20)
                {
                    brand = value;
                }
                else 
                {
                    throw new ArgumentException("Fabrikat är inte mellan 2 och 20 tecken lång");
                }
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length >= 2 && value.Length <= 20)
                {
                    model = value;
                }
                else
                {
                    throw new ArgumentException("Modell är inte mellan 2 och 20 tecken lång");
                }
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 1886 && value <= DateTime.Now.Year)
                {
                    year = value;
                }
                else
                {
                    throw new ArgumentException($"Årtal ej mellan 1886 och {DateTime.Now.Year} ");
                }
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            { 
                if ( value > 0)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException($"Vikten ej ett positivt värde");
                }
            }
        }
        public override string ToString()
        {
            return $"Fabrikat: {Brand}\t\tModell: {Model}\tÅr: {Year}\t Vikt: {Weight}";
        }
        public Vehicle(string brand, string model, int year, double weight)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Weight = weight;
        }
    }
}

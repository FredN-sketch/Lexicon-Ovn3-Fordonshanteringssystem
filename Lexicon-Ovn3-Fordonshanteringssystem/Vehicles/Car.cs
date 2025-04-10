﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Ovn3_Fordonshanteringssystem.Vehicles
{
    internal class Car : Vehicle, ICleanable
    {
        public int NumberOfDoors { get; set; }
        public Car(string brand, string model, int year, double weight, int numberOfDoors) : base("Car", brand, model, year, weight)
        {
            NumberOfDoors = numberOfDoors;
        }
        public override string ToString()
        {
            return $"Typ: {Type}\tFabrikat: {Brand}\tModell: {Model}\tÅr: {Year}\t Vikt: {Weight}\tAntal dörrar: {NumberOfDoors}";
        }
        public override void StartEngine()
        {
            Console.WriteLine("Bilen startar...");
        }
        public void Clean()
        {
            Console.WriteLine("Tvättar bilen!");
        }
    }
}

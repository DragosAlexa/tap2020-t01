﻿using System;
using Uaic.Tema2.Core.Assets;
using Uaic.Tema2.Core.Calculators;


namespace Tema2
{
    partial class Program
    {
        static void Main(string[] args) {
            var studioCommisionCalculator = new StudioCommissionCalculator();
            var studioTotalPriceCalc = new StudioTotalPriceCalculator();
            var apartmentCommisionCalculator = new ApartmentCommissionCalculator();
            var apartmentTotalPriceCalc = new ApartmentTotalPriceCalculator();
            var houseCommisionCalculator = new HouseCommissionCalculator();
            var houseTotalPriceCalc = new HouseTotalPriceCalculator();
            var landCommisionCalculator = new LandCommissionCalculator();
            var landTotalPriceCalc = new LandTotalPriceCalculator();
            Studio studio = new Studio(25000m,20, 1985,"Str.Salciilor,nr.2");
            
            
            RealEstatePrice.GetTotalPriceFrom(studio, studio.price,studioTotalPriceCalc);
            RealEstatePrice.GetCommissionFrom(studio, studio.price, studioCommisionCalculator);
            Console.WriteLine("The address of studio: " + studio.address);
            //Console.WriteLine("Studio price:{0} and commission:{1} Address of studio:{2} .",studioTotalPriceCalc.CalculateTotalPrice(studio,studio.price),studioTotalPriceCalc.CalculateTotalPrice(studio,studio.price) ,studio.address);
            Apartment apartment = new Apartment(65000m,45, 1990, "Str.Vamesilor, nr.5");
            RealEstatePrice.GetTotalPriceFrom(apartment, apartment.price,apartmentTotalPriceCalc);
            RealEstatePrice.GetCommissionFrom(apartment, apartment.price, apartmentCommisionCalculator);
            Console.WriteLine("The address of apartment: " + apartment.address);
            //Console.WriteLine("Apartment price:" + apartmentTotalPriceCalc.CalculateTotalPrice(apartment,apartment.price) + " and commission: " +apartmentCommisionCalculator.CalculateCommission(apartment,apartment.price));
            House house = new House(70000m, 70, 2014,3,"Str.Lalelelor, Horpaz");
            RealEstatePrice.GetTotalPriceFrom(house, house.price, houseTotalPriceCalc);
            RealEstatePrice.GetCommissionFrom(house, house.price, houseCommisionCalculator);
            Console.WriteLine("The address of house: " + house.address);
            //Console.WriteLine("House price:" + houseTotalPriceCalc.CalculateTotalPrice(house, house.price) + " and commission: " + houseCommisionCalculator.CalculateCommission(house, house.price));
            Land land = new Land(40000m,"URBAN",1245, 1005000);
            RealEstatePrice.GetTotalPriceFrom(land, land.price, landTotalPriceCalc);
            RealEstatePrice.GetCommissionFrom(land, land.price, landCommisionCalculator);
            Console.WriteLine("The cadastral number of "+land.type.ToLower()+" land: " + land.cadastral_number);
            //Console.WriteLine("Land price:" + landTotalPriceCalc.CalculateTotalPrice(land, land.price) + " and commission: " + landCommisionCalculator.CalculateCommission(land, land.price));


        }

    }
}



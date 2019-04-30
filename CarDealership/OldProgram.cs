// using System;
// using System.Collections.Generic;
//
// // namespace CarDealership {
//
//   public class Program
//   {
//     public static void Main()
//     {
//       Car porsche = new Car("2014 Porsche 911", 114991, 7864, "this car will over inflate your already overly inflated ego!");
//       Car ford = new Car("2011 Ford F450", 55995, 14241,  "this car is great at handling heavy loads!");
//       Car lexus = new Car("2013 Lexus RX 350", 44700, 20000, "drive your 1.5 kids to and from soccer practice in luxury.");
//       Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979, "cut in front of the peons with class!");
//
//       List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
//
//       lexus.SetPrice(2000);
//
      // Console.WriteLine("Enter maximum price: ");
      // string stringMaxPrice = Console.ReadLine();
      // int maxPrice = int.Parse(stringMaxPrice);
      //
      // Console.WriteLine("Enter maximum miles: ");
      // string stringMaxMiles = Console.ReadLine();
      // int maxMiles = int.Parse(stringMaxMiles);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.PriceCheck(maxPrice)&&(automobile.MilesCheck(maxMiles)))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }
      if (CarsMatchingSearch.Count == 0)
      {
        Console.WriteLine("No cars match your search.");
      }


      // foreach(Car automobile in CarsMatchingSearch)
      // {
      //   Console.WriteLine("----------------------");
      //   Console.WriteLine(automobile.GetMakeModel());
      //   Console.WriteLine(automobile.GetMiles() + " miles");
      //   Console.WriteLine("$" + automobile.GetPrice());
      //   Console.WriteLine(automobile.GetMessage());
      // }

//     }
//   }
//
// }

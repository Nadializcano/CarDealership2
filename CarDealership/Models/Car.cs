using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
public class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;
    private string Message;
    private static List<Car> _instances = new List<Car> {};

    public Car(string makeModel, int price, int miles, string message)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Message = message;
      _instances.Add(this);
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }
    public void SetMakeModel(string newMakeModel)
    {
      MakeModel = newMakeModel;
    }
    public int GetPrice()
    {
      return Price;
    }
    public int GetMiles()
    {
      return Miles;
    }
    public string GetMessage()
    {
      return Message;
    }

    public bool PriceCheck(int maxPrice)
    {
      return (Price < maxPrice);
    }
    public bool MilesCheck(int maxMiles)
    {
      return (Miles < maxMiles);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }

}

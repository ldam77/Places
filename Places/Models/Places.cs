using System;
using System.Collections.Generic;

namespace Places.Models
{
  public class PlacesObject
  {
    private string city;
    private string length;
    private int id;
    private static List<PlacesObject> newPlaces = new List<PlacesObject> {};

    public PlacesObject(string newCity, string newLength)
    {
      city = newCity;
      length = newLength;
      newPlaces.Add(this);
      id = newPlaces.Count;
    }
    public string GetCity()
    {
      return city;
    }
    public int GetId()
    {
      return id;
    }
    public string GetLength()
    {
      return length;
    }
    public static PlacesObject Find(int searchId)
    {
      return newPlaces[searchId - 1];
    }
    public static List<PlacesObject> GetAll()
    {
      return newPlaces;
    }
    public static void ClearAll()
    {
      newPlaces.Clear();
    }
  }
}

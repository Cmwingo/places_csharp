using System.Collections.Generic;

namespace TravelLog.Objects
{
  public class Place
  {
    private string _cityName;
    private int _id;
    private static List<Place> _instances = new List<Place> {};

    public Place (string cityName)
    {
      _cityName = cityName;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetCityName()
    {
      return _cityName;
    }
    public void SetCityName(string newCityName)
    {
      _cityName = newCityName;
    }

    public int GetId()
    {
      return _id;
    }
    public static List<Place> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}

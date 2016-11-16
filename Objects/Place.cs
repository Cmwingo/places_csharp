using System.Collections.Generic;

namespace TravelLog.Objects
{
  public class Place
  {
    private string _cityName;
    private string _description;
    private string _photoFile;
    private int _id;
    private static List<Place> _instances = new List<Place> {};

    public Place (string cityName, string description, string photoFile)
    {
      _cityName = cityName;
      _description = description;
      _photoFile = photoFile;
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
    public string GetPhotoFile()
    {
      return _photoFile;
    }
    public void SetPhotoFile(string newPhotoFile)
    {
      _photoFile = newPhotoFile;
    }
    public string GetCityDescription()
    {
      return _description;
    }
    public void SetCityDescription(string newCityDescription)
    {
      _description = newCityDescription;
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

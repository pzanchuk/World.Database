using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;


namespace World.Models
{
  public class City
  {

    private string _name;
    private int _population;


    public static List<City> allCities = new List<City> {};

    public City(string name, int population)
    {

      _name = name;
      _population = population;
    }

    public string getName()
    {
      return _name;
    }

    public int getPopulation()
    {
      return _population;
    }

    public static List<City> GetAll(string name)
    {
      allCities.Clear();
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM city WHERE name = '"+name+"';";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;

      while(rdr.Read())
      {
        string cityName = rdr.GetString(1);
        int population = rdr.GetInt32(4);
        City newCity = new City(cityName, population);
        allCities.Add(newCity);
      }
      conn.Close();

      if(conn != null)
      {
        conn.Dispose();
      }
      return allCities;
    }

  }
}

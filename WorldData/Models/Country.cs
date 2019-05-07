using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace WorldData.Models
{
  public class Country
  {
      private static List<Country> _instances = new List<Country> {};
      private string _countryName;
      private int _countryPopulation;
      private float _countryExpectancy;
      private string _countryCode;

      public Country(string countryName, int countryPopulation, float countryExpectancy, string countryCode)
      {
          _countryName = countryName;
          _countryPopulation = countryPopulation;
          _countryExpectancy = countryExpectancy;
          _countryCode = countryCode;
          _instances.Add(this);
      }

      public string CountryName { get => _countryName; set => _countryName = value;}
      public int CountryPopulation { get => _countryPopulation; set => _countryPopulation = value;}
      public float CountryExpectancy { get => _countryExpectancy; set => _countryExpectancy = value;}
      public string CountryCode { get => _countryCode; set => _countryCode = value;}

      public static void ClearAll()
      {
          _instances.Clear();
      }

      public static List<Country> GetAll()
      {
          List<Country> allCountries = new List<Country> {};
          MySqlConnection conn = DB.Connection();
          conn.Open();
          MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
          cmd.CommandText = @"SELECT Name, Population, LifeExpectancy, Code FROM country ORDER BY Name;";
          MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
          while(rdr.Read())
          {
              string countryName = rdr.GetString(0);
              int countryPopulation = rdr.GetInt32(1);
              float countryExpectancy = 1;
              string countryCode = rdr.GetString(3);
              if(!rdr.IsDBNull(2))
              {
                  countryExpectancy = rdr.GetFloat(2);
              }
              Country newCountry = new Country(countryName, countryPopulation, countryExpectancy, countryCode);
              allCountries.Add(newCountry);
          }
          conn.Close();
          if (conn != null)
          {
              conn.Dispose();
          }
          return allCountries;
      }

    }
}

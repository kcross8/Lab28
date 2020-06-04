using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace _601WebAPI_Intro.Models
{
    public class SwapiDAL
    {
        public string GetAPIJson(string endpoint, int Id)
        {
            string url = $"https://swapi.dev/api/{endpoint}/{Id}/";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Convert the response into something useable 
            //stream is basically another word for 'file'
            StreamReader sr = new StreamReader(response.GetResponseStream());
            string output = sr.ReadToEnd();
            return output;
        }
        public Person GetPerson(string endpoint, int Id)
        {
            string personData = GetAPIJson(endpoint, Id);
            //need to get nuget package 'Newtonsoft.json' for JsonConvert
            Person p = JsonConvert.DeserializeObject<Person>(personData);

            return p;
        }
        public Planet GetPlanet(string endpoint, int Id)
        {
            string planetData = GetAPIJson(endpoint, Id);
            Planet p = JsonConvert.DeserializeObject<Planet>(planetData);

            return p;
        }
        public Starship GetStarship(string endpoint, int Id)
        {
            string starshipData = GetAPIJson(endpoint, Id);
            Starship s = JsonConvert.DeserializeObject<Starship>(starshipData);

            return s;
        }
    }
}

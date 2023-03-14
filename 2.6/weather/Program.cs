using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Net;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace weather
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?lat=56.488712&lon=84.952324&units=metric&appid=1e7d57281c303495a33c9c3e4332068e";
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            string answer;
            using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
            {
                answer = streamReader.ReadToEnd();
            }
            WeatherInfo.root info =  JsonSerializer.Deserialize<WeatherInfo.root>(answer);
            Console.Write($"{info.name}\n Температура: {info.main.temp} (ощущается как {info.main.feels_like})\n Скорость ветра: {info.wind.speed} м/c");
        }
    }
}
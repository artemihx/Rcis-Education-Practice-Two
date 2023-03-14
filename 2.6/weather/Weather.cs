namespace weather
{
    class WeatherInfo
        {
            public class main
            {
                public double temp { get; set; }
                public double feels_like { get; set; }
            }

            public class wind
            {
                public int speed { get; set; }
            }

            public class root
            {
                 public main main { get; set; }
                 public wind wind { get; set; }
                 public string name { get; set; }
            }
        }
    }

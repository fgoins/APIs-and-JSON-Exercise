using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static void Weather()
        {
          var Client = new HttpClient();
            var key = "37593bfc559c6f42cc7a0fe61d20a288";
            var city = "Dallas";

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}";
            var response = Client.GetStringAsync(weatherURL).Result;

            var formattedResponse = JObject.Parse(response).GetValue("main");
            Console.WriteLine(formattedResponse);
        }
    }
}

// client 
//end point  store the url in a variable type var in a string.

// get request = client.getstringasync(pass in the end point var).result; and store it in a variable

//parse = storr in a var name = jarrayORobject.parse(request variable name);

//cw the parse variable(name[use indexing to get the line you want])
// ex. cw(the parse variable);

//we use indexing to grab specific parts
// ex.  cw(the parse variable[then grab the index you want to show][name of the of the object]); --for objects
// obj cw(name[0]["car"]);
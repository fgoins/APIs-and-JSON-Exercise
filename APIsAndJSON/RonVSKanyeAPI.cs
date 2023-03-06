using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json.Nodes;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        public static void Kanye()
        {
            var Client = new HttpClient();
            var KanyeURL = "https://api.kanye.rest/";
            var KanyeConvo = Client.GetStringAsync(KanyeURL).Result;
            var KanyeReponse = JsonObject.Parse(KanyeConvo);
            Console.WriteLine();
            Console.WriteLine($"Kanye said : {KanyeReponse}.");
            Console.WriteLine();

        }
        public static void Ron()
        {
            var Client = new HttpClient();
            var RonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var RonConvo = Client.GetStringAsync(RonURL).Result;
            var RonResponse = JsonArray.Parse(RonConvo);
            Console.WriteLine();
            Console.WriteLine($" and Ron said : {RonResponse[0]}.");
            Console.WriteLine();
        }



    }
}
// client var Client = new HttpClient();

//end point  store the url in a variable type var in a string.

// get request = client.getstringasync(pass in the end point var).result; and store it in a variable

//parse = storr in a var name = jarrayORobject.parse(request variable name);

//cw the parse variable(name[use indexing to get the line you want])
// ex. cw(the parse variable);

//we use indexing to grab specific parts
// ex.  cw(the parse variable[then grab the index you want to show][name of the of the object]); --for objects
// obj cw(name[0]["car"]);
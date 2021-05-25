using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Kayne
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var client = new HttpClient();
            var urlK = "https://api.kanye.rest";                                // access to url "end point" hit to pull quotes for below
            var urlR = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

           // var responseK = client.GetStringAsync(urlK).Result;               // these calls need to be in the for loop so that a new quote will be generated.
           // var responseR = client.GetStringAsync(urlR).Result;

           // Console.WriteLine(responseK);                                      // when run if it opens with { do .JObject.Parse  if opens with  [  need to do JArray.Parse
           // Console.WriteLine(responseR);

           // var quoteK = JObject.Parse(responseK).GetValue("quote").ToString();  // ctrl .  adds using statement  .GetVlaue("quote") puts only the words
           // var quoteR = JArray.Parse(responseR).ToString().Replace('[', ' ').Replace(']', ' ').Replace('"', ' ').Trim();
            
           // Console.WriteLine($"Kanye: { quoteK} ");
           // Console.WriteLine($"Ron: {quoteR} ");

            for (int i = 0; i < 5; i++)                               // starts here  and runs thru the for loop to pull the next quote
            {
                var responseK = client.GetStringAsync(urlK).Result;  // client.Post or .Put or .Delete only if have access to do so (to create an API - bonus lecture)
                var responseR = client.GetStringAsync(urlR).Result;

                var quoteK = JObject.Parse(responseK).GetValue("quote").ToString();  // ctrl .  adds using statement  .GetVlaue("quote") puts only the words
                var quoteR = JArray.Parse(responseR).ToString().Replace('[', ' ').Replace(']', ' ').Replace('"', ' ').Trim();

                Console.WriteLine($"Kanye: {quoteK} ");
                Console.WriteLine($"Ron: {quoteR} ");
                Console.WriteLine("*******************");
            }
        }
    }  //cldonnen2001    TrueCoders2021
}

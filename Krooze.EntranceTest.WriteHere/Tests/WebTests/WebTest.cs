using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;

namespace Krooze.EntranceTest.WriteHere.Tests.WebTests
{
    public class WebTest
    {
        public JObject Movies { get; set; } = null;

        public JObject GetAllMovies()
        {
            //TODO: Consume the following API: https://swapi.co/documentation using only .NET standard libraries (do not import the helpers on this page)
            // -Return the films object

            using (var client = new HttpClient())
            {
                var response = client.GetAsync("https://swapi.co/api/films/").Result;
                if (response.IsSuccessStatusCode)
                {
                    string content = response.Content.ReadAsStringAsync().Result;
                    Movies = JObject.Parse(content);
                    return Movies;
                }
            }

            return null;
        }

        public string GetDirector()
        {
            //TODO: Consume the following API: https://swapi.co/documentation using only .NET standard libraries (do not import the helpers on this page)
            // -Return the name of person that directed the most star wars movies, based on the films object return
            JObject films = (Movies ?? GetAllMovies());
            var filmsArray = films["results"].Values<JObject>();
            var directors = filmsArray.Select(x => x["director"].Value<string>()).GroupBy(g => g).ToArray();

            int tronoCount = 0, indexTrono = 0;
            // bubble short
            for (int i = 0; i < directors.Length; i++)
            {
                if (directors.Count() > tronoCount)
                {
                    tronoCount = directors.Count();
                    indexTrono = i;
                }
            }

            return directors[indexTrono].Key;
        }

    }
}

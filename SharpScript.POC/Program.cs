using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServiceStack;
using ServiceStack.Script;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SharpScript.POC
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /**
             * Buscar dados de covid 19
             * https://brasil.io/
             */
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                var covidCities = new List<CoronaData>();
                using (var response = await client.GetAsync("https://brasil.io/api/dataset/covid19/caso_full/data/?place_type=city&is_last=True&page_size=10000"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    response.EnsureSuccessStatusCode();
                    covidCities = JsonConvert.DeserializeObject<List<CoronaData>>(JObject.Parse(apiResponse)["results"].ToString());
                }
                string scriptText = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "query.ss"));
                var context = new ScriptContext()
                {
                    Args = {
             ["cities"] = covidCities
             },
                }.Init();
                var output = await context.RenderScriptAsync(scriptText);
                Console.WriteLine(output);
            }
        }
    }
}

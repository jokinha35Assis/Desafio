using MavelApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MavelApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index([FromServices] IConfiguration config)
        {

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string ts = DateTime.Now.Ticks.ToString();
                string publicKey = config.GetSection("MarvelComicsAPI:PublicKey").Value;
                string hash = GerarHash(ts, publicKey,
                config.GetSection("MarvelComicsAPI:PrivateKey").Value);


                HttpResponseMessage response = client.GetAsync(
                    config.GetSection("MarvelComicsAPI:BaseURL").Value +
                    $"comics?ts={ts}&apikey={publicKey}&hash={hash}").Result;

                response.EnsureSuccessStatusCode();

                string conteudo = response.Content.ReadAsStringAsync().Result;
                dynamic resultado = JsonConvert.DeserializeObject(conteudo);

                var comics = new List<Comics>();

                for (int i = 0; i < 1; i++)
                {
                    comics.Add(new Comics()
                    {
                        Id = resultado.data.results[i].id,
                        Title = resultado.data.results[i].title,
                        UPC = resultado.data.results[i].upc,
                        URL = resultado.data.results[i].resourceURI,
                        Image = resultado.data.results[i].thumbnail.path + "." + resultado.data.results[i].thumbnail.extension,
                        Details = resultado.data.results[i].urls[0].url
                    });
     
                }

                return View(comics);
            }
        }

        private string GerarHash(string ts, string publicKey, string privateKey)
        {
            byte[] bytes =
                Encoding.UTF8.GetBytes(ts + privateKey + publicKey);
            var gerador = MD5.Create();
            byte[] bytesHash = gerador.ComputeHash(bytes);
            return BitConverter.ToString(bytesHash)
                .ToLower().Replace("-", String.Empty);
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}

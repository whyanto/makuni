using Makuni1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Makuni1.Services
{
    class ApiService
    {
        public static async Task<List<Tuote>> HaeTuote(string search)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync($"http://makuni.azurewebsites.net/api/Tuotteet/TuoteAlkaa?={search}");
            return JsonConvert.DeserializeObject<List<Tuote>>(response);
        }
        public static async Task<List<Tuote>> UusimmatTuotteet()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync($"http://makuni.azurewebsites.net/api/Tuotteet/UusimmatTuotteet");
            return JsonConvert.DeserializeObject<List<Tuote>>(response);
        }
        public static async Task<List<Tuote>> HaeTuoteEan(string ean)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync($"http://makuni.azurewebsites.net/api/Tuotteet/Tuote?={ean}");
            return JsonConvert.DeserializeObject<List<Tuote>>(response);
        }
        public static async Task<List<Allergeeni>> HaeTuotetteenAllergeenit(string ean)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync($"http://makuni.azurewebsites.net/api/Tuotteet/HaeAllergeenit?={ean}");
            return JsonConvert.DeserializeObject<List<Allergeeni>>(response);
        }
        public static async Task<List<Ravintoarvot>> HaeTuotetteenRavintoarvot(string ean)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync($"http://makuni.azurewebsites.net/api/Tuotteet/HaeRavintoarvot?={ean}");
            return JsonConvert.DeserializeObject<List<Ravintoarvot>>(response);
        }
    }
}

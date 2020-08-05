using System;
using System.Net.Http;
using System.Threading.Tasks;
using SunlightApp.Models;

namespace SunlightApp.Services
{
    public class SunriseSunsetService : ISunRiseService
    {
        public async Task<Results> GetData(decimal? lat, decimal? lng)
        {
            string url;
            if (lat == 0 && lng == 0)
                url = $"https://api.sunrise-sunset.org/json?lat=59.392&lng=17.8241586";
            else
                url = $"https://api.sunrise-sunset.org/json?lat={lat}&lng={lng}";

            using (HttpResponseMessage response = await ApiHelper.ApiHelper.apiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    SunriseSunsetDataModel model = await response.Content.ReadAsAsync<SunriseSunsetDataModel>();
                    return model.Results;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}

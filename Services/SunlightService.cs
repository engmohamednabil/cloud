using System;
using System.Net.Http;
using System.Threading.Tasks;
using SunlightApp.Models;

namespace SunlightApp.Services
{
    public class SunlightService : ISunLightService
    {
        public async Task<sunlightDataModel> GetData(int? itemNumber)
        {
            string url;
            if (itemNumber.HasValue && itemNumber > 0)
                url = $"http://xkcd.com/{itemNumber}/info.0.json";
            else
                url = $"http://xkcd.com/info.0.json";

            using (HttpResponseMessage response = await ApiHelper.ApiHelper.apiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    sunlightDataModel model = await response.Content.ReadAsAsync<sunlightDataModel>();
                    return model;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
         
    }
}

using SunlightApp.Models;
using System.Threading.Tasks;

namespace SunlightApp.Services
{
    public interface ISunLightService
    {
        public Task<sunlightDataModel> GetData(int? itemNumber);
    }
}
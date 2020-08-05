using SunlightApp.Models;
using System.Threading.Tasks;

namespace SunlightApp.Services
{
    public interface ISunRiseService
    {
        public Task<Results> GetData(decimal? lat, decimal? lng);
    }
}
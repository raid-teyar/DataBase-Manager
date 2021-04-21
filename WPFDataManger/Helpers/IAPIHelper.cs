using System.Threading.Tasks;
using WPFDataManger.Models;

namespace WPFDataManger.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}
using System.Threading.Tasks;
using WPFDataManager.Library.Models;

namespace WPFDataManager.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task<LoggedInUserModel> GetLoggedInUserInfo(string token);
    }
}  
using System.Threading.Tasks;
using CWDesktopUI.Models;

namespace CWDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}
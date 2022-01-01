using IPClient.Shared.Model;
using System.Threading.Tasks;

namespace IPClient.Shared.IServices
{
    public interface IPingService
    {
        Task<Response> TestServer();
    }
}
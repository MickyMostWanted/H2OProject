using System.Threading.Tasks;
namespace Unheard.Services.Interfaces
{
    public interface IDatabase
    {
        Task<int> SaveItemAsync(UserProfile item);
    }
}












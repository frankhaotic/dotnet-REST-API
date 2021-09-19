using System.Threading.Tasks;

namespace Supermarket.API.Domains.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
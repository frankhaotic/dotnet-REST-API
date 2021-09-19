using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domains.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
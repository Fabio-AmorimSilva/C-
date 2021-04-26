using System.Collections.Generic;
using System.Threading.Tasks;
using Packt.CS7;

namespace NorthwindBlazorServer.Data
{
    public interface INorthwindService
    {
         Task<List<Customer>> GetCustomersAsync();
         Task<Customer> GetCustomerAsync(string id);
         Task<Customer> CreateCustomerAsync(Customer c);
         Task<Customer> UpdateCustomerAsync(Customer c);
         Task DeleteCustomerAsync(string id);
    }
}
using SimpleMvvmToolkit.Samples.WPF.Core.Models;

namespace SimpleMvvmToolkit.Samples.WPF.Core.Services
{
    public class MockCustomerService : ICustomerService
    {
        // Create a fake customer
        public Customer CreateCustomer()
        {
            return new Customer
            {
                CustomerId = 1,
                CustomerName = "John Doe",
                City = "Dallas"
            };
        }
    }
}
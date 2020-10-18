
using AssistPurchase.Models;

namespace AssistPurchase.Repository
{
    public interface ICustomerAlertRepository
    {
        public void AddCustomer(CustomerModel customer);
        public CustomerModel FindCustomer(string customerId);
        public void SendEmail(CustomerModel customer);
    }
}

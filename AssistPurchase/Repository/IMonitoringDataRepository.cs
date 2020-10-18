using System.Collections.Generic;
using AssistPurchase.Models;

namespace AssistPurchase.Repository
{
    public interface IMonitoringDataRepository
    { 
        IEnumerable<MonitoringProducts> GetAllProducts();
        void AddNewProduct(MonitoringProducts product);
        string UpdateProduct(MonitoringProducts product);
        MonitoringProducts RemoveProduct(string productNumber);
        MonitoringProducts FindProduct(string productNumber);
    }
}

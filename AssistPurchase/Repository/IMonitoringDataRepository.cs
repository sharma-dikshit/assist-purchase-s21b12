using System.Collections.Generic;
using AssistPurchase.Models;

namespace AssistPurchase.Repository
{
    public interface IMonitoringDataRepository
    { 
        IEnumerable<MonitoringProducts> GetAllProducts();
        void AddNewProduct(MonitoringProducts product); //ReSharper disable all
        string UpdateProduct(MonitoringProducts product);
        MonitoringProducts RemoveProduct(string productNumber); //ReSharper restore all
        MonitoringProducts FindProduct(string productNumber);
    }
}

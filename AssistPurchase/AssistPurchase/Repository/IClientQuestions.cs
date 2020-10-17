using System.Collections.Generic;
using AssistPurchase.Models;

namespace AssistPurchase.Repository
{
   public interface IClientQuestions
   {
       IEnumerable<MonitoringProducts> GetProducts();
       string GetProductDescription(string productNumber);
       IEnumerable<MonitoringProducts> GetProductTouchScreenFeature(string touchScreenValue);
       IEnumerable<MonitoringProducts> GetProductWearableMonitorFeature(string wearableMonitorValue);
       IEnumerable<MonitoringProducts> GetProductAlarmManagement(string alarmManagementValue);
       IEnumerable<MonitoringProducts> GetProductBelowPrice(string price);
       IEnumerable<MonitoringProducts> GetProductAbovePrice(string price);
       IEnumerable<MonitoringProducts> GetProductBelowScreenSize(string screenSize);
       IEnumerable<MonitoringProducts> GetProductAboveScreenSize(string screenSize);
       IEnumerable<MonitoringProducts> GetProductConnectivitySupport(string connectivitySupportValue);
       IEnumerable<MonitoringProducts> GetProductSummarizeDataSupport(string summarizeDataValue);
       IEnumerable<MonitoringProducts> GetProductScalableMeasurementSupport(string scalableMeasurementValue);
       IEnumerable<MonitoringProducts> GetProductCompactFeature(string compactValue);
   }
}

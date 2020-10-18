using System.Collections.Generic;
using AssistPurchase.Models;

namespace AssistPurchase.Repository
{
    public class ClientQuestions: MonitoringDataRepository,IClientQuestions
    {
        public IEnumerable<MonitoringProducts> GetProducts()
        {
            return GetAllProducts();
        }

        public string GetProductDescription(string productNumber)
        {
            var product = FindProduct(productNumber);
            return product.ProductDescription;
        }

        public IEnumerable<MonitoringProducts> GetProductTouchScreenFeature(string touchScreenValue)
        {
            var touchScreenFeatureList = new List<MonitoringProducts>();

            foreach (var product in MonitoringProductDb)
            {
                if (product.TouchScreen == touchScreenValue)
                {
                   touchScreenFeatureList.Add(product);
                }
            }
            return touchScreenFeatureList;
        }

        public IEnumerable<MonitoringProducts> GetProductWearableMonitorFeature(string wearableMonitorValue)
        {
          var wearableMonitorFeatureList = new List<MonitoringProducts>();

            foreach (var product in MonitoringProductDb)
            {
                if (product.WearableMonitor == wearableMonitorValue)
                {
                    wearableMonitorFeatureList.Add(product);
                }
            }
            return wearableMonitorFeatureList;
        }

        public IEnumerable<MonitoringProducts> GetProductAlarmManagement(string alarmManagementValue)
        {
            var alarmManagementFeatureList = new List<MonitoringProducts>();

            foreach (var product in MonitoringProductDb)
            {
                if (product.AlarmManagement == alarmManagementValue)
                {
                    alarmManagementFeatureList.Add(product);
                }
            }
            return alarmManagementFeatureList;
        }

        public IEnumerable<MonitoringProducts> GetProductBelowPrice(string price)
        {
            var belowPriceList = new List<MonitoringProducts>();

            foreach (var product in MonitoringProductDb)
            {
                if (int.Parse(product.Cost) <= int.Parse(price))
                {
                    belowPriceList.Add(product);
                }
            }
            return belowPriceList;
        }

        public IEnumerable<MonitoringProducts> GetProductAbovePrice(string price)
        {
            var abovePriceList = new List<MonitoringProducts>();

            foreach (var product in MonitoringProductDb)
            {
                if (int.Parse(product.Cost) >= int.Parse(price))
                {
                    abovePriceList.Add(product);
                }
            }
            return abovePriceList;
        }

        public IEnumerable<MonitoringProducts> GetProductBelowScreenSize(string screenSize)
        {
           var belowScreenSizeList = new List<MonitoringProducts>();

            foreach (var product in MonitoringProductDb)
            {
                if (int.Parse(product.ScreenSize) <= int.Parse(screenSize))
                {
                    belowScreenSizeList.Add(product);
                }
            }
            return belowScreenSizeList;
        }

        public IEnumerable<MonitoringProducts> GetProductAboveScreenSize(string screenSize)
        {
            var aboveScreenSizeList = new List<MonitoringProducts>();

            foreach (var product in MonitoringProductDb)
            {
                if (int.Parse(product.ScreenSize) >= int.Parse(screenSize))
                {
                    aboveScreenSizeList.Add(product);
                }
            }
            return aboveScreenSizeList;
        }

        public IEnumerable<MonitoringProducts> GetProductConnectivitySupport(string connectivitySupportValue)
        {
            var connectivitySupportList = new List<MonitoringProducts>();

            foreach (var product in MonitoringProductDb)
            {
                if (product.ConnectivitySupport == connectivitySupportValue)
                {
                    connectivitySupportList.Add(product);
                }
            }
            return connectivitySupportList;
        }

        public IEnumerable<MonitoringProducts> GetProductSummarizeDataSupport(string summarizeDataValue)
        {
            var summarizeDataList = new List<MonitoringProducts>();

            foreach (var product in MonitoringProductDb)
            {
                if (product.SummarizeDataSupport == summarizeDataValue)
                {
                    summarizeDataList.Add(product);
                }
            }
            return summarizeDataList;
        }

        public IEnumerable<MonitoringProducts> GetProductScalableMeasurementSupport(string scalableMeasurementValue)
        {
            var scalableMeasurementList = new List<MonitoringProducts>();

            foreach (var product in MonitoringProductDb)
            {
                if (product.ScalableMeasurement == scalableMeasurementValue)
                {
                    scalableMeasurementList.Add(product);
                }
            }
            return scalableMeasurementList;
        }

        public IEnumerable<MonitoringProducts> GetProductCompactFeature(string compactValue)
        {
            var compactFeatureList = new List<MonitoringProducts>();

            foreach (var product in MonitoringProductDb)
            {
                if (product.Compact == compactValue)
                {
                    compactFeatureList.Add(product);
                }
            }
            return compactFeatureList;

        }
    }
}

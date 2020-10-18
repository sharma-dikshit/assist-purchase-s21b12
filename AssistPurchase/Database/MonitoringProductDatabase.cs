using AssistPurchase.Models;
using System.Collections.Generic;

namespace AssistPurchase.Database
{
    public class MonitoringProductDatabase
    {
        public List<MonitoringProducts> ProductDb { get;private set;}
        public MonitoringProductDatabase()
        {
            AddProducts();
        }
        private void AddProducts()
        {
            var monitoringProductDb = new List<MonitoringProducts>
            {
                new MonitoringProducts
                {
                    ProductNumber = "X3",
                    ProductName = "IntelliVue",
                    ProductDescription =
                        "The Philips IntelliVue X3 is a compact, dual-purpose, transport patient monitor featuring intuitive smartPhone-style operation and offering a scalable set of clinical measurements.",
                    TouchScreen = "YES",
                    WearableMonitor = "NO",
                    AlarmManagement = "NO",
                    Cost = "14567",
                    ScreenSize = "6.5",
                    ConnectivitySupport = "NO",
                    SummarizeDataSupport = "NO",
                    ScalableMeasurement = "YES",
                    Compact = "YES"
                },

                new MonitoringProducts
                {
                    ProductNumber = "MX450",
                    ProductName = "IntelliVue",
                    ProductDescription =
                    "The IntelliVue MX450 combines powerful monitoring with flexible portability in one compact unit. Supplying comprehensive patient information at a glance, it can make a real difference when multiple patients and priorities need attention.",
                    TouchScreen = "YES",
                    WearableMonitor = "NO",
                    AlarmManagement = "NO",
                    Cost = "38790",
                    ScreenSize = "12",
                    ConnectivitySupport = "YES",
                    SummarizeDataSupport = "YES",
                    ScalableMeasurement = "NO",
                    Compact = "NO"
                },

                new MonitoringProducts
                {
                    ProductNumber = "MX40",
                    ProductName = "IntelliVue",
                    ProductDescription =
                    "The IntelliVue MX40 patient wearable monitor gives you technology, intelligent design, and innovative features you expect from Philips – in a device light enough and small enough to be comfortably worn by ambulatory patients.",
                    TouchScreen = "YES",
                    WearableMonitor = "YES",
                    AlarmManagement = "YES",
                    Cost = "24650",
                    ScreenSize = "5.2",
                    ConnectivitySupport = "NO",
                    SummarizeDataSupport = "NO",
                    ScalableMeasurement = "YES",
                    Compact = "NO"
                },

                new MonitoringProducts
                {
                    ProductNumber = "MX400",
                    ProductName = "IntelliVue",
                    ProductDescription =
                    "The IntelliVue MX400 provides powerful monitoring in a highly compact, highly transportable unit. Supplying comprehensive patient information at a glance, it can make a real difference when multiple patients and priorities need attention.",
                    TouchScreen = "YES",
                    WearableMonitor = "NO",
                    AlarmManagement = "NO",
                    Cost = "28608",
                    ScreenSize = "9",
                    ConnectivitySupport = "YES",
                    SummarizeDataSupport = "YES",
                    ScalableMeasurement = "NO",
                    Compact = "YES"
                }
            };

            ProductDb = monitoringProductDb;
        }
    }
}

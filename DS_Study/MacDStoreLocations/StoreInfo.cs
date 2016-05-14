using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacDStoreLocations
{
    class StoreInfo
    {

        public String storeName;
        public int Distance;
        public int profit;
        public int index;

        public StoreInfo()
        {
            storeName = string.Empty;
            Distance = 0;
            profit = 0;
            index = 0;
        }

        public StoreInfo(int iDis, int iProfit, int iIndex) : this()
        {
            Distance = iDis;
            profit = iProfit;

            index = iIndex;
        }

    }
}

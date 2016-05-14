using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacDStoreLocations
{
    class Compute
    {
        private StoreInfo[] stores;
        private int MinDistance;

        int[,] profitArray;

        int LastStoreLocation;
        int NoOfStores;

        public Compute(StoreInfo[] stores, int MinDistance)
        {
            this.stores = stores;
            this.MinDistance = MinDistance;

            LastStoreLocation = stores.Last().Distance;
            NoOfStores = stores.Length;

            profitArray = new int[NoOfStores + 1, LastStoreLocation + 1];

            PerformComputation();

            int MaxProfit = profitArray[NoOfStores, LastStoreLocation];
        }

        private void PerformComputation()
        {
            // our array is of larger dimension then no of stores. 
            // so there is difference of 1 in Store array and profit array
            for (int iStore = 1; iStore < NoOfStores + 1; iStore++)
            {
                for (int iDis = 0; iDis < LastStoreLocation + 1; iDis++)
                {
                    if (iDis < stores[iStore - 1].Distance)
                    {
                        profitArray[iStore, iDis] = profitArray[iStore - 1, iDis];
                    }
                    else
                    {
                        int iStoLoc = GetValidIndex(iStore - 1);
                        profitArray[iStore, iDis] = Math.Max(profitArray[iStore - 1, iDis], profitArray[iStoLoc, iDis] + stores[iStore - 1].profit);
                    }
                }
            }
        }

        private int GetValidIndex(int iIndex)
        {
            for (int i = iIndex - 1; i >= 0; i--)
            {
                if (stores[iIndex].Distance - stores[i].Distance >= MinDistance)
                    return i + 1;
            }
            return 0;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacDStoreLocations
{
    class Program
    {
        static void Main(string[] args)
        {

            StoreInfo[] stores = new StoreInfo[10]
            {
                new StoreInfo(2,50,0),
                new StoreInfo(5,20,1),
                new StoreInfo(9,30,2),
                new StoreInfo(12,50,3),
                new StoreInfo(20,10,4),
                new StoreInfo(35,10,5),
                new StoreInfo(40,10,6),
                new StoreInfo(45,10,7),
                new StoreInfo(65,10,8),
                new StoreInfo(70,10,9)
            };
            int MinDistance = 5;

            //StoreInfo[] stores = new StoreInfo[8]
            //{
            //    new StoreInfo(3,20,0),
            //    new StoreInfo(10,10,1),
            //    new StoreInfo(12,50,2),
            //    new StoreInfo(21,70,3),
            //    new StoreInfo(23,40,4),
            //    new StoreInfo(26,30,5),
            //    new StoreInfo(31,60,6),
            //    new StoreInfo(40,50,7)
            //};
            //int MinDistance = 10;

            Compute a = new Compute(stores, MinDistance);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinCoinsForAmount
{
    class Compute
    {
        private int[] coinsArray;
        int[,] array;

        public Compute(int[] coins)
        {
            this.coinsArray = coins;
        }

        public int GetMinNo(int iAmount)
        {
            array = new int[coinsArray.GetLength(0) + 1, iAmount + 1];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = 0;

                    if(i == 1)
                    {
                        array[i, j] = j;
                    }
                }
            }


            for (int iCoin = 2; iCoin < array.GetLength(0); iCoin++)
            {
                for (int amount = 0; amount < iAmount + 1; amount++)
                {
                    array[iCoin, amount] = Math.Min(array[iCoin-1, amount], amount / coinsArray[iCoin - 1] + array[iCoin-1, amount % coinsArray[iCoin - 1]]);
                }
            }

            return array[array.GetLength(0)-1, array.GetLength(1)-1];

        }
    }
}

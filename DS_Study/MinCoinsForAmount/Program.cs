using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinCoinsForAmount
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] coins = new int[5] { 1, 2, 5, 10, 20 };
            int[] coins = new int[3] { 1, 8, 10 };
            Compute aCom = new Compute(coins);

            int noOfCoins = aCom.GetMinNo(25);
            noOfCoins = aCom.GetMinNo(16);
            noOfCoins = aCom.GetMinNo(20);
            noOfCoins = aCom.GetMinNo(21);
            noOfCoins = aCom.GetMinNo(22);
            noOfCoins = aCom.GetMinNo(23);
            noOfCoins = aCom.GetMinNo(24);
            noOfCoins = aCom.GetMinNo(25);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveMoreBacktracking
{
    class Backtracking
    {
        bool[] OccupancyArray; //to keep track of which digits are used
        int[] valueArray;
        int foundIndex = 0;
        List<String> resultArray;

        //  S E N D
        //  M O R E
        //M O N E Y

        //charValue[0] = S
        //charValue[1] = e
        //charValue[2] = n
        //charValue[3] = d
        //charValue[4] = m
        //charValue[5] = o
        //charValue[6] = r
        //charValue[7] = y

        public Backtracking()
        {
            OccupancyArray = new bool[10];
            valueArray = new int[8] { 0,1,2,3,4,5,6,7 }; // as there are 8 chars which are used
            resultArray = new List<string>();

            for (int i = 0; i < 8; i++)
            { 
                OccupancyArray[valueArray[i]] = true;
            }

            for (int i = 7; i >= 0; i--)
            {
                OccupancyArray[valueArray[i]] = false;
                Start(i);
            }
            PrintValues(); 
        }

                                                                                                            
        private void Start(int index)                                                                            
        {                                                                                                        
            for (int i = 0; i < 10; i++)
            {

                if (OccupancyArray[i] == true)
                    continue;

                valueArray[index] = i;
                OccupancyArray[i] = true;

                if (true == isValidArrangement())
                {
                    StoreValues();
                }

                if (index < 7)
                {
                    Start(index + 1);
                }
                OccupancyArray[i] = false;
            }

        }

        public void StoreValues()
        {
            StringBuilder aStr = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                aStr.Append(valueArray[i]);
            }

            bool isFound = false;
            foreach (string  aString in resultArray)
            {
                if(string.Compare(aStr.ToString(), aString) == 0)
                {
                    isFound = true;
                    break;
                }
            }

            if (false == isFound)
                resultArray.Add(aStr.ToString());                                          
        }

        private void PrintValues()
        {
            foreach (string item in resultArray)
            {
                Debug.WriteLine("****************************");
                Debug.WriteLine(foundIndex);
                Debug.WriteLine(item);
                foundIndex++;
            }
        }

        private bool isValidArrangement()
        {
            int firstNo = 1000 * valueArray[0] + 100 * valueArray[1] + 10 * valueArray[2] + valueArray[3];
            int secoundNo = 1000 * valueArray[4] + 100 * valueArray[5] + 10 * valueArray[6] + valueArray[1];
            int Sum = 10000 * valueArray[4] + 1000 * valueArray[5] + 100 * valueArray[2] + 10 * valueArray[1] + valueArray[7];

            if ((firstNo + secoundNo) == Sum)
                return true;
            else
                return false;
        }

    }
}

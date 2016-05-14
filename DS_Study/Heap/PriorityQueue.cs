using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Heap
{
    public class PriorityQueue
    {
        private const int MaxSize = 40;

        private int[] arr = new int[MaxSize]; 

        public PriorityQueue()
        {

            this.addNode(2);
            this.addNode(3);
            this.addNode(5);
            this.addNode(44);
            this.addNode(30);
            this.addNode(22);
            this.addNode(25);
            this.addNode(6);
            this.addNode(7);
            this.addNode(8);
            this.addNode(11);
            this.addNode(15);
            this.addNode(1);

            this.addNode(2);
            this.addNode(3);
            this.addNode(5);
            this.addNode(44);
            this.addNode(30);
            this.addNode(22);
            this.addNode(25);
            this.addNode(6);
            this.addNode(7);
            this.addNode(8);
            this.addNode(11);
            this.addNode(15);
            this.addNode(1);
            
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();

            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();

            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode(); 
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();
            this.RemoveNode();


        }

        private void addNode(int aValue)
        {
            if (arr[0] == MaxSize - 1)
            {
                //MessageBox.Show("asdf");
                Debug.WriteLine("Need to increase size of array");
                return;
            }

            arr[0]++;
            arr[arr[0]] = aValue;

            RestoreUp();
        }

        private void RemoveNode()
        {
            if (0 == arr[0])
            {
                return;
            }

            arr[1] = arr[arr[0]];
            arr[0]--;

            RestoreDown();

        }

        private void RestoreUp()
        {
            for (int x = arr[0] / 2; x > 0; x--)
            {
                int leaf1 = arr[2*x];

                if (leaf1 < arr[x])
                {
                    swap(ref arr[2 * x], ref arr[x]);
                }

                if ((2 * x + 1) <= arr[0])
                {
                    if (arr[2*x + 1] < arr[x])
                    {
                        swap(ref arr[2 * x + 1], ref arr[x]);
                    }
                }

            }
        }

        private void swap(ref int p1, ref int p2)
        {
            int temp = p1;
            p1 = p2;
            p2 = temp;
        }

        private void RestoreDown()
        {

            for (int i = 0; i < (int)(arr[0] / 2); i++)
            {
                if (arr[i] > arr[2 * i])
                {
                    swap(ref arr[i], ref arr[2 * i]);
                }

                // check if index  2*i + 1 ... exist
                if (arr[0] >= arr[2 * i + 1])
                {
                    if (arr[i] > arr[2 * i + 1])
                    {
                        swap(ref arr[i], ref arr[2 * i + 1]);

                    }
                }
            }
        }

        
    }
}

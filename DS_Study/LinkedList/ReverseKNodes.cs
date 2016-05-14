using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class ReverseKNodes
    {

//        /* Reverses the linked list in groups of size k and returns the
//   pointer to the new head node. */
//struct node *reverse (struct node *head, int k)
//{
//    struct node* current = head;
//    struct node* next;
//    struct node* prev = NULL;
//    int count = 0;  
     
//    /*reverse first k nodes of the linked list */
//    while (current != NULL && count < k)
//    {
//       next  = current->next;
//       current->next = prev;
//       prev = current;
//       current = next;
//       count++;
//    }
     
//    /* next is now a pointer to (k+1)th node
//       Recursively call for the list starting from current.
//       And make rest of the list as next of first node */
//    if(next !=  NULL)
//    {  head->next = reverse(next, k); }
 
//    /* prev is new head of the input list */
//    return prev;
//}




        int Kset;

        public Node ReverseNode(Node aHead, int i)
        {
            Kset = i;
            Node temp;
            Node current = aHead;
            Node previous = null;
            Node finalH = null;
            Node last = null;

            while (current != null)
            {
                int k = 0;
                previous = null;

                while(current != null && k< Kset)
                {
                    temp = current.Next;
                    current.Next = previous;
                    previous = current;
                    current = temp;

                    k++;
                }

                if(finalH == null)
                { 
                    finalH = previous; 
                }
                else
                {
                    last.Next = previous;
                }

                last = previous;
                while (last.Next != null)
                {
                    last = last.Next;
                }

            }
            return finalH;





        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    class StringTrie
    {

        public TrieNode rootNode;
        String[] allStrings;
        int findCount = 0;

        public StringTrie()
        {
            rootNode = new TrieNode();
            AddStringInTrie("any");
            AddStringInTrie("anyother");
            AddStringInTrie("anything");
            AddStringInTrie("ab");
            AddStringInTrie("abc");
            AddStringInTrie("acb");
            AddStringInTrie("anyone");
            AddStringInTrie("there");
            AddStringInTrie("their");
            AddStringInTrie("answer");
            AddStringInTrie("bye");

            Boolean IsPresent = FindString("abc");
            IsPresent = FindString("answer");
            IsPresent = FindString("abc");
            IsPresent = FindString("there");
            IsPresent = FindString("abc");

            FindAllStringSuggestionsWith("an");
        }

        private void FindAllStringSuggestionsWith(string p)
        {
            allStrings = new string[10];
            int index = 0;
            TrieNode aNode = rootNode; 

            while(index < p.Length)
            {
                if (aNode.charArray[p[index] - 97] != null)
                {
                    aNode = aNode.charArray[p[index] - 97];
                }
                else
                {
                    aNode = null;
                    break;
                }
                index++;
            }

            if(aNode == null)
            {
                return;
            }

            FindSuggestion(p, aNode);

        }

        private void FindSuggestion(string p, TrieNode aNode)
        {
            if (aNode.IsEndWord == true)
            {
                allStrings[findCount] = p;
                findCount++;
            } 

            for (int i = 0; i < aNode.charArray.Length; i++)
            {
                if(aNode.charArray[i] != null)
                {
                    FindSuggestion(p + Convert.ToChar(i + 97), aNode.charArray[i]);
                }
            }

        }

        private bool FindString(string strFind)
        {
            return FindStringInTrie(strFind, rootNode, 0);
        }

        private bool FindStringInTrie(string strFind, TrieNode rootNode, int index)
        {
            if(rootNode.charArray[strFind[index] -97] == null)
            {
                return false;
            }

            if(index < strFind.Length -1 )
            {
                return FindStringInTrie(strFind, rootNode.charArray[strFind[index] - 97], ++index);
            }
            else
            {
                if (rootNode.IsEndWord == true)
                    return true;
                else
                    return false;

            }
        }

        private void AddStringInTrie(String aString)
        {
            if(String.IsNullOrWhiteSpace(aString))
            {
                return;
            }

            AddChar(aString, rootNode, 0);
        }

        private void AddChar(String strString, TrieNode aNode, int index)
        {

            if(aNode.charArray[strString[index] - 97] == null)
            {
                TrieNode newNode = new TrieNode();
                newNode.Value = strString[index];
                aNode.charArray[strString[index]-97] = newNode;

                if(index == strString.Length - 1)
                {
                    newNode.IsEndWord = true;
                }
            }

            if (index < strString.Length - 1)
            {
                AddChar(strString, aNode.charArray[strString[index] - 97], ++index);
            }

        }


    }
}

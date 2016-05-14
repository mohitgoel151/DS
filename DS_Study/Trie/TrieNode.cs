using System;

namespace Trie
{
    class TrieNode
    {

        public Char Value;
        public bool IsEndWord;
        public TrieNode[] charArray;

        public TrieNode()
        {
            IsEndWord = false;
            charArray = new TrieNode[26];
        }

        public TrieNode(char aChar) : this()
        {
            Value = aChar;
        }

    }
}

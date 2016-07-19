using System.Collections.Generic;
using System.Text;

namespace AnagramWebsite.Models
{
    internal class Node
    {
        public string Word { get; }
        public int WordNumber { get; }
        public Node ParentNode { get; }

        public Node(string word, Node parentNode, int wordNumber)
        {
            Word = word;
            ParentNode = parentNode;
            WordNumber = wordNumber;
        }

        public string GetFullPhrase()
        {
            var stringBuilder = new StringBuilder();
            var stack = new Stack<string>();
            var tempNode = ParentNode;

            while (tempNode != null && tempNode.WordNumber != 0)
            {
                stack.Push(tempNode.Word);
                tempNode = tempNode.ParentNode;
            }

            while (stack.Count > 0)
            {
                stringBuilder.Append(stack.Pop()).Append(" ");
            }

            stringBuilder.Append(Word);

            return stringBuilder.ToString();
        }
    }
}

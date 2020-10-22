using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.String
{
    public class StringReverse
    {
        public static string Reverse(string text)
        {
            int textEnd = text.Length - 1;
            int iterateEnd = text.Length / 2;
            StringBuilder textCopy = new StringBuilder(text);
            for (int i = 0; i < iterateEnd; ++i)
            {
                char front = textCopy[i];
                char back = textCopy[textEnd - i];
                textCopy[i] = back;
                textCopy[textEnd - i] = front;
            }
            return textCopy.ToString();
        }
    }
}

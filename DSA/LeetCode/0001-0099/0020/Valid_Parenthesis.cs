using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
   
    public static bool IsValid(string str)
    {
        Stack<char> st = new Stack<char>();

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '(' || str[i] == '{' || str[i] == '[')
            {
                st.Push(str[i]);
            }
            else
            {
                if (st.Count == 0) return false; if (str[i] == '}' && st.Peek() != '{') return false; if (str[i] == ')' && st.Peek() != '(') return false; if (str[i] == ']' && st.Peek() != '[') return false;

                st.Pop();
            }


        }
        return st.Count == 0;
    }
}
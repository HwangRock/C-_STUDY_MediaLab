using System;
using System.Collections.Generic;

class Solution
{
    public bool solution(string s)
    {
        bool answer = true;
        int fin = s.Length;
        Stack<char> stack = new Stack<char>();
        for(int i= 0; i < fin; i++)
        {
            char cur = s[i];
            if (cur == '(')
            {
                stack.Push(cur);
            }
            else
            {
                if(stack.Count == 0)
                {
                    answer = false;
                    break;
                }
                stack.Pop();
            }
        }
        if (stack.Count > 0)
        {
            answer = false;
        }
        return answer;
    }
}

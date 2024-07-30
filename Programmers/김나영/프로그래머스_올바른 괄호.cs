using System;
using System.Collections.Generic;

public class Solution {
    public bool solution(string s) {
                       bool answer = true;
               Stack<char> stacker = new Stack<char>();             
               for (int i = 0; i < s.Length; i++)
               {
                   if (s[i] == '(')
                   {
                       stacker.Push(s[i]);
                   }
                   else
                   { 
                       if (stack.Count == 0)
                       { answer = false;
                       break;}
                       stacker.Pop(); 
                   }

               }
               if (stacker.Count > 0) 
               { answer = false; }
        return answer;
    }
}

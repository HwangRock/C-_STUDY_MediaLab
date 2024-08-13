using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "Yes";
        
        Queue<String> S_cards1 = new Queue<String>();
        Queue<String> S_cards2 = new Queue<String>();
        
        for (int i = 0; i<cards1.Length; i++)
        {
            S_cards1.Enqueue(cards1[i]);
        }
        for (int j = 0; j<cards2.Length; j++)
        {
            S_cards2.Enqueue(cards2[j]);
        }
        
        for ( int n=0; n<goal.Length; n++)
        {
        if (S_cards1.Count != 0 && goal[n]==S_cards1.Peek())
        {
            S_cards1.Dequeue();
        }
        else if (S_cards2.Count != 0 && goal[n]==S_cards2.Peek())
        {
            S_cards2.Dequeue();
        }
        else{answer="No"; break;}
        }
        
        return answer;
    }
}

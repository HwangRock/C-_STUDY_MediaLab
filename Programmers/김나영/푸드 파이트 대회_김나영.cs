using System;
using System.Collections.Generic;

public class Solution {
    public string solution(int[] food) {
        List<int> list = new List<int>();
        for (int i=0; i<food.Length; i++)
        {
            if (food[i]%2!=0)
            {
                food[i]+=1;                    
            }
            for (int j=0; j<=food[i]/2; j++)
            {
                list.Add(food[i]);
            }
        }
        List<int> Re = list.Reverse();
        
        string answer = list.ToString+"0"+Re.ToString;
        return answer;
    }
}

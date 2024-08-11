using System;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        int length = d.Length;
        
        Array.Sort(d);
        for(int i = 0; i < length; ++i)
            {
                if(budget >= d[i])
                {
                    budget -= d[i];
                    answer++;
                }
            }
        return answer;
    }
}

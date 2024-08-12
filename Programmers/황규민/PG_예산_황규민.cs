using System;

public class Solution
{
    public int solution(int[] d, int budget)
    {
        int answer = 0;
        int fin=d.Length;
        Array.Sort(d);
        for(int i = 0;i<fin;i++)
        {
            int cur = d[i];
            if (cur <= budget)
            {
                answer++;
                budget -= cur;
            }
        }
        return answer;
    }
}

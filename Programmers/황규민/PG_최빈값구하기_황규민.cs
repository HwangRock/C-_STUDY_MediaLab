using System;

public class Solution
{
    public int solution(int[] array)
    {
        int answer = 0;
        int[] num = new int[1001];
        int fin = array.Length;
        bool able = true;
        int maxi = 0;
        int want = 0;

        for(int i = 0; i < fin; i++)
        {
            int cur = array[i];
            num[cur]++;
        }
        for(int i = 0; i < 1000; i++)
        {
            int cur = num[i];
            if (maxi < cur)
            {
                maxi = cur;
                want = i;
                able = true;
            }
            else if (maxi == cur)
            {
                able = false;
            }
        }

        if (able)
        {
            answer = want;
        }
        else
        {
            answer = -1;
        }
        return answer;
    }
}

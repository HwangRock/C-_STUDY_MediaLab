using System;

public class Solution
{
    public int[] solution(int num, int total)
    {
        int[] answer = new int[num];
        int mid = total / num;
        if (num % 2 == 1)
        {
            int surplus = num / 2;
            int seq = 0;
            for(int i=mid-surplus; i <= mid + surplus; i++)
            {
                answer[seq] = i;
                seq++;
            }
        }
        else
        {
            int surplus = num / 2;
            int seq = 0;
            for (int i = mid - surplus + 1; i <= mid + surplus; i++)
            {
                answer[seq] = i;
                seq++;
            }
        }
        return answer;
    }
}

using System;

public class Solution
{
    public int[] solution(int[,] score)
    {
        int fin = score.GetLength(0);
        int[] answer = new int[fin];
        int[] num = new int[fin];
        bool[] visit = new bool[fin];
        for (int i = 0; i < fin; i++)
        {
            int cur = score[i, 0] + score[i, 1];
            num[i] = cur;
        }

        int seq = 0;
        int before = -1;
        for(int i = 0; i < fin; i++)
        {
            int maxi = -1;
            int idx = 0;
            for(int j = 0; j < fin; j++)
            {
                if (visit[j] == false)
                {
                    if (num[j] > maxi)
                    {
                        maxi = num[j];
                        idx = j;
                        seq = i + 1;
                    }
                }
            }
            visit[idx] = true;
            if (i>0 && num[idx] == num[before])
            {
                answer[idx] = answer[before];
            }
            else
            {
                answer[idx] = seq;
            }
            before = idx;
        }
        return answer;
    }
}

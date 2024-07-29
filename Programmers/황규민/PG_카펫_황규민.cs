using System;

public class Solution
{
    public int[] solution(int brown, int yellow)
    {
        int[] answer = new int[2];
        bool able = false;
        for (int i = 1; i <= 100000000; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                int yn = i * j;
                int bn = 2 * i + 2 * j + 4;
                if (yn == yellow && bn == brown)
                {
                    able = true;
                    answer[0] = i + 2;
                    answer[1] = j + 2;
                    break;
                }
            }
            if (able)
            {
                break;
            }
        }

        return answer;
    }
}

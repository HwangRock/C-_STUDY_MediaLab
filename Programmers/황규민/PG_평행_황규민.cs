using System;

public class Solution
{
    public int solution(int[,] dots)
    {
        int k = 0, j = 0;
        for(int i = 1; i < 4; i++)
        {
            if (i == 1)
            {
                k = 2; j = 3;
            }
            else if (i == 2)
            {
                k = 1; j = 3;
            }
            else if(i == 3)
            {
                k = 1; j = 2;
            }
            //기울기 공식에서 양 변의 분모를 곱함.
            int left = (dots[i, 1] - dots[0, 1]) * (dots[k, 0] - dots[j, 0]);
            int right = (dots[i, 0] - dots[0, 0]) * (dots[k, 1] - dots[j, 1]);
            if (left == right)
            {
                return 1;
            }
        }
        return 0;
    }
}

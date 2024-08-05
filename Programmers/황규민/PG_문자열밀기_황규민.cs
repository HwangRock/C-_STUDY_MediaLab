using System;

public class Solution
{
    public int solution(string A, string B)
    {
        int answer = 0;
        int seq = 0;
        bool able = false;

        int fin = A.Length;
        for(int i = 0; i < fin; i++)
        {
            //Console.WriteLine(A);
            if (A == B)
            {
                able = true;
                break;
            }
            char temp = A[fin - 1];
            A=A.Remove(fin - 1);
            A = temp + A;
            seq++;
        }
        if (able)
        {
            answer = seq;
        }
        else
        {
            answer = -1;
        }
        return answer;
    }
}

using System;
public class Solution
{
    public int solution(string A, string B)
    {
        int answer = 0;        
        int fin = A.Length;

        for (int i = 0; i < fin; i++)
        {
            if (A == B)
            {
                
                break;
            }

            char temp = A[fin - 1];
            A=A.Remove(fin - 1);
            A = temp + A;
            answer++;
        }

        if (answer==fin)
        {
            answer = -1;
        }

        return answer;
    }
}

using System;
public class Solution
{
    public int[] solution(long n)
    {
        string s = n.ToString();
        int fin = s.Length;
        int[] answer = new int[fin];
        for (int i = 0; i < fin; i++)
        {
            answer[i] = s[i] - '0';
        }
        Array.Reverse(answer);
        return answer;
    }
}

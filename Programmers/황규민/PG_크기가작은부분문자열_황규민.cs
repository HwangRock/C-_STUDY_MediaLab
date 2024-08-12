using System;

public class Solution
{
    public int solution(string t, string p)
    {
        int answer = 0;
        int start = 0, end = p.Length;
        long num = long.Parse(p);
        int fin = t.Length;

        while (end <= fin)
        {
            string s = t.Substring(start, end - start);
            long cur = long.Parse(s);
            if (cur <= num)
            {
                answer++;
            }
            start++;
            end++;
        }

        return answer;
    }
}

using System;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        string[] num = s.Split();
        int fin = num.Length;
        int[] number = new int[fin];
        for (int i = 0; i < fin; i++)
        {
            number[i] = int.Parse(num[i]);
        }
        Array.Sort(number);
        string first = number[0].ToString();
        string last = number[fin-1].ToString();
        answer = first + " " + last;
        return answer;
    }
}

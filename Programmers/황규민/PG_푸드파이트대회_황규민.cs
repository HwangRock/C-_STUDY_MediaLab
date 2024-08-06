using System;
using System.Linq;

public class Solution
{
    public string solution(int[] food)
    {
        string answer = "";
        string left = "";
        int fin = food.Length;
        for(int i = 1; i < fin; i++)
        {
            if (food[i] % 2 != 0)
            {
                food[i] -= 1;
            }
            food[i] /= 2;
        }
        for(int i = 1; i < fin; i++)
        {
            int num = food[i];
            char cur = (char)('0' + i);
            left += new string(cur, num);
        }
        string right = new string(left.Reverse().ToArray());

        answer = left + '0' + right;
        return answer;
    }
}

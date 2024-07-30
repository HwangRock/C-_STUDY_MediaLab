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
            //int로 바꾸면 아스키코드값을 갖게된다. '0'은 48, '1'은 49 이런식으로. 이때 '1'에서 '0'을 빼면 그대로 1을 얻게 되는 방식으로 char에서 int로 변환.
        }
        Array.Reverse(answer);
        return answer;
    }
}

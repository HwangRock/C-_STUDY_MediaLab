using System;

public class Solution
{
    public string[] solution(string[] quiz)
    {
        int fin=quiz.Length;
        string[] answer = new string[fin];
        for(int i=0; i < fin; i++)
        {
            bool dap = false;
            string cur = quiz[i];
            string[] num=cur.Split(' ');
            string cal = num[1];
            int one = int.Parse(num[0]);
            int two = int.Parse(num[2]);
            int thr = int.Parse(num[4]);
            if (cal == "+")
            {
                if (one + two == thr)
                {
                    dap = true;
                }
                else
                {
                    dap = false;
                }
            }
            else
            {
                if (one - two == thr)
                {
                    dap = true;
                }
                else
                {
                    dap = false;
                }
            }
            if (dap)
            {
                answer[i] = "O";
            }
            else
            {
                answer[i] = "X";
            }
        }

        return answer;
    }
}

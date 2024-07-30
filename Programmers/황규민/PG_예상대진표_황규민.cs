using System;

class Solution
{
    int div(int n)
    {
        if (n % 2 == 0)
        {
            n /= 2;
        }
        else
        {
            n = n / 2 + 1;
        }
        return n;
    }
    public int solution(int n, int a, int b)
    {
        

        int answer = 1;

        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        while(true)
        {

            if ((a % 2 == 1 && b % 2 == 0) && (b == a + 1))
            {
                break;
            }

            a =div(a);
            b=div(b);
            answer += 1;
            //Console.WriteLine(a+" "+b);
        }

        return answer;
    }
}

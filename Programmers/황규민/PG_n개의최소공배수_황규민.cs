//유클리드 호제법에 대한 부연설명
//https://blog.naver.com/hwang_rock/223213352287

public class Solution
{
    int gcd(int n, int m)
    {
        if (m > n)
        {
            int temp = n;
            n = m;
            m = temp;
        }
        if (m == 0)
        {
            return n;
        }

        else
        {
            int r = n % m;
            n = m;
            m = r;
            return gcd(n, m);
        }
    }

    int lcm(int n, int m)
    {
        return (n * m) / gcd(n, m);
    }

    public int solution(int[] arr)
    {
        int answer = 0;
        int fin = arr.Length;
        if (fin == 1)
        {
            answer = arr[0];
        }
        else
        {
            int val = lcm(arr[0], arr[1]);
            for(int i=2;i<fin; i++)
            {
                val=lcm(val, arr[i]);
            }
            answer = val;
        }
        return answer;
    }
}

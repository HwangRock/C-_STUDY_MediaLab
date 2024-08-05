using System;

public class Solution
{
    // 최대공약수를 구하는 함수 
    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // 최소공배수를 구하는 함수
    private int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);
    }

    // 주어진 배열의 모든 원소의 최소공배수를 구하는 함수
    public int solution(int[] arr)
    {
        int lcm = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            lcm = LCM(lcm, arr[i]);
        }

        return lcm;
    }
}

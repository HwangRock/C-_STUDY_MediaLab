using System;
using System.Linq;

public class Solution
{
    public int solution(int[] A, int[] B)
    {
        // 배열을 오름차순 및 내림차순으로 정렬
        Array.Sort(A);
        Array.Sort(B, (x, y) => y.CompareTo(x)); // 내림차순 정렬

        int result = 0;

        // 배열 A와 B의 같은 인덱스의 값끼리 곱하여 결과를 누적
        for (int i = 0; i < A.Length; i++)
        {
            result += A[i] * B[i];
        }

        return result;
    }
}

using System;

public class Solution {
    public int solution(int[] A, int[] B) {
        int answer = 0;
        int mult=0;
        Array.Sort(A);
        Array.Sort(B);
        Array.Reverse(B);
        for (int i=0; i<A.Length; i++)
        {
            mult+=A[i]*B[i];
        }
        answer=mult;
        return answer;
    }
}

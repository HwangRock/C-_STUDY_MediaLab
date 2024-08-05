//실행 시간 10초 초과
using System;
public class Solution {
    public int solution(string A, string B) {
        int answer = 0;
        int t = 0;       
    for (int i = 0; i < A.Length; i++) {
        if (A == B) {           
            break;
        }
        t = A[A.Length - 1];
        A = t + A;
        A.Remove(A.Length - 1);
        answer++;        
    }                   
    if (A!=B)
    {
            answer = -1;
        }        
        return answer;
    }
}

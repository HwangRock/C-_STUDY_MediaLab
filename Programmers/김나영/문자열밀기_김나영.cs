using System;

public class Solution {
    public int solution(string A, string B) {
        int answer = 0;
        int[] a = new int[] {};
        
        if (A==B)
        {
            answer = "0";
            break;
        }
        
        for(int i=1; i<A.Length; i++)
        {
            a.Add(A[i]);
        }      

        if (a==B)
        {
            answer = "1";
        }
        else if (a!=B)
        {
            answer = "-1";
        }
        
        return answer;
    }
}

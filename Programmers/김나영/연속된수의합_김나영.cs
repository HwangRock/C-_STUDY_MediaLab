using System;

public class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[] {};
        for (a = 1; a <= total; a++)
        {
            if(total == (2a + (num-1)) * num / 2) //등차수열 공식
            {
                for (i = 0; i <=num; i++)
                {
                    answer.Add(a+i);
                }
                
            }
        }   
        return answer;
    }
}

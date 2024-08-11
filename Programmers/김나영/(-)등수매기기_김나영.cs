using System;

public class Solution {
    public int[] solution(int[,] score) {
        int[] answer = new int[] {};
        int length = score.Length;
                   for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length ; j++)
                {
                    int[] average += (score[i]+score[j])/2;
                }
                    
            }

        
        
        return answer;
    }
}

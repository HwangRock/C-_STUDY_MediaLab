using System;

public class Solution {
    public int solution(int[] common) {
        int answer = 0;
        int last=common.Length;
        if (common[1]-common[0]==common[2]-common[1])
        {
            int plus=common[1]-common[0];
            answer=common[last-1]+plus;            
        }

        else
        {
            int gap=common[1]/common[0];
            answer=common[last-1]*gap;
        }
        return answer;
    }
}

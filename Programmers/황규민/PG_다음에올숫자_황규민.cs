using System;

public class Solution {
    public int solution(int[] common) {
        int answer = 0;
        int a = common[0];
        int b = common[1];
        int c = common[2];
        int fin=common.Length;
        if (b - a == c - b)
        {
            int interval = b - a;
            answer = common[fin - 1] + interval;
        }
        else if (b * b == a * c)
        {
            int ratio = b / a;
            answer = common[fin - 1] * ratio;
        }
        return answer;
    }
}

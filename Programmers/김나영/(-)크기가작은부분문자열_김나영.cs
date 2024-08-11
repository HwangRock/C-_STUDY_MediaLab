//런타임 에러
using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        int tl = t.Length;
        int pl = p.Length;            
        int num = 0;
        
        for(int i = 0; i < tl - pl + 1; i++)
        {
            num = int.Parse(t.Substring(i, pl)); 
            if(num <= int.Parse(p))
            { 
                answer++;
            }
        }
        return answer;
    }
}

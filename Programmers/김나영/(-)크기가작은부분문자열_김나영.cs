using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        int tl = t.Length;
        int pl = p.Length;            
        long num = 0;
        
        for(int i = 0; i < tl - pl + 1; i++)
        {
            num = long.Parse(t.Substring(i, pl));  //Substring(int, int) 와야해서 얘들은 int형 이여야함
            if(num <= long.Parse(p))
            { 
                answer++;
            }
        }
        return answer;
    }
}

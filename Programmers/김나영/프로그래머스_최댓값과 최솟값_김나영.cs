using System;

public class Solution {
    public string solution(string v) {
                    string[] S = v.Split();
            int[] ints = Array.ConvertAll(S, s => int.Parse(s));

            int length = S.Length;

            Array.Sort(ints);

            string answer = ints[0] + " " + ints[length - 1];
        return answer;
    }
}

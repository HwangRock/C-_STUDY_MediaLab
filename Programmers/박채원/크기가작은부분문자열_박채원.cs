using System;

public class Solution {
    public int solution(string t, string p) {
        // p의 길이
        int pLength = p.Length;
        // p를 정수로 변환
        long pValue = long.Parse(p);
        // t의 길이
        int tLength = t.Length;
        // 카운트 변수
        int count = 0;

        // t에서 p의 길이만큼의 부분 문자열을 순회하며
        for (int i = 0; i <= tLength - pLength; i++) {
            // 부분 문자열 추출
            string substring = t.Substring(i, pLength);
            // 부분 문자열을 정수로 변환
            long substringValue = long.Parse(substring);
            // p의 값보다 작거나 같은 경우 카운트 증가
            if (substringValue <= pValue) {
                count++;
            }
        }

        return count;
    }
}

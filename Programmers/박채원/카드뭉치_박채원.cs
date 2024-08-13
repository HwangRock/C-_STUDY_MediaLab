using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        int index1 = 0, index2 = 0;

        foreach (string word in goal) {
            // 현재 단어가 cards1에 있는 경우
            if (index1 < cards1.Length && cards1[index1] == word) {
                index1++;
            }
            // 현재 단어가 cards2에 있는 경우
            else if (index2 < cards2.Length && cards2[index2] == word) {
                index2++;
            }
            // 둘 다 아니라면 goal을 만들 수 없음
            else {
                return "No";
            }
        }

        return "Yes";
    }
}

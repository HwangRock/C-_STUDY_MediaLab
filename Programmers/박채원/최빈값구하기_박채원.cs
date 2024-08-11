using System;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
        // 배열의 각 숫자가 몇 번 등장했는지를 저장할 배열
        int[] count = new int[1000];
        
        // 숫자 등장 횟수 계산
        foreach (int num in array) {
            count[num]++;
        }
        
        // 최빈값 찾기
        int maxCount = count.Max(); // 가장 많이 등장한 횟수
        int maxCountNum = Array.IndexOf(count, maxCount); // 최빈값
        bool isUnique = count.Count(x => x == maxCount) == 1; // 최빈값이 유일한지 확인
        
        // 최빈값이 유일하면 그 값을 반환, 그렇지 않으면 -1 반환
        return isUnique ? maxCountNum : -1;
    }
}

using System;

public class Solution
{
    public int[] solution(int[] arr)
    {
        // 배열의 길이가 1인 경우, [-1]을 반환
        if (arr.Length == 1)
        {
            return new int[] { -1 };
        }

        // 배열에서 가장 작은 수 찾기
        int minValue = arr.Min();

        // 가장 작은 수를 제외한 새로운 배열 생성
        int[] result = arr.Where(x => x != minValue).ToArray();

        return result;
    }
}

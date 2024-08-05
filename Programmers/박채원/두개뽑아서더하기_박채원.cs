using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] numbers)
    {
        // 중복을 피하기 위해 HashSet 사용
        HashSet<int> sums = new HashSet<int>();

        // 두 수를 선택해서 합을 구함
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                sums.Add(numbers[i] + numbers[j]);
            }
        }

        // HashSet을 배열로 변환 후 정렬
        int[] result = new List<int>(sums).ToArray();
        //오름차순 정렬
        Array.Sort(result);

        return result;
    }
}

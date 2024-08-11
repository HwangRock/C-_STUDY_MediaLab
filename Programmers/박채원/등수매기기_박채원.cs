using System;
using System.Linq;

public class Solution
{
    public int[] solution(int[,] score)
    {
        // 다차원 배열을 배열의 배열로 변환합니다.
        int[][] j_Array = new int[score.GetLength(0)][];

        for (int i = 0; i < score.GetLength(0); i++)
        {
            j_Array[i] = new int[score.GetLength(1)];
            for (int j = 0; j < score.GetLength(1); j++)
            {
                j_Array[i][j] = score[i, j];
            }
        }

        // 각 학생의 평균 점수를 계산합니다.
        var averages = j_Array.Select(s => (s[0] + s[1]) / 2.0).ToList();

        // 평균 점수를 기준으로 등수를 매깁니다. 내림차순정렬
        var s_Averages = averages.OrderByDescending(x => x).ToList();

        // 각 학생의 등수를 저장할 배열을 만듭니다.
        int[] ranks = new int[j_Array.Length];

        // 학생별로 등수를 할당합니다.
        for (int i = 0; i < j_Array.Length; i++)
        {
            ranks[i] = s_Averages.IndexOf(averages[i]) + 1;
        }

        return ranks;
    }
}

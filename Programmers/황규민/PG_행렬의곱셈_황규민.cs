using System;

public class Solution
{
    public int[,] solution(int[,] arr1, int[,] arr2)//arr1*arr2의 상황.
    {
        int connect = arr1.GetLength(1);//앞 행렬의 행 (곱해진 행렬의 행)
        int sero = arr1.GetLength(0);//앞 행렬의 열이자 뒤 행렬의 열 (두 행렬이 곱해질 수 있게함.)
        int garo = arr2.GetLength(1);//뒤 행렬의 열 (곱해진 행렬의 열)
        int[,] answer = new int[sero, garo];
        for(int i = 0; i < garo; i++)
        {
            for(int j=0; j < sero; j++)
            {
                for(int k=0;k<connect; k++)
                {
                    answer[j, i] += arr1[j, k] * arr2[k, i];//내적 연산
                }
            }
        }
        return answer;
    }
}

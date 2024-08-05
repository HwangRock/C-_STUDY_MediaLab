//프로그래머스_x만큼 간격이 있는 n개의 숫자
using System;
public class Solution
{
    public long[] solution(int x, int n)
    {
        // 결과를 저장할 배열 선언 (n개의 원소)
        long[] result = new long[n];

        // x부터 시작해 x씩 증가하는 숫자를 n개 지니는 리스트 생성
        for (int i = 0; i < n; i++)
        {
            // i번째 원소는 (i + 1) * x로 계산
            result[i] = (long)(i + 1) * x;
        }

        return result;
    }
}

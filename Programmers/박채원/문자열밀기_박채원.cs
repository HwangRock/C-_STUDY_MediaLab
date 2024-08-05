using System;

public class Solution
{
    public int solution(string A, string B)
    {
        // 문자열의 길이가 다르면 회전이 불가능하므로 -1 반환
        if (A.Length != B.Length)
        {
            return -1;
        }

        // A와 B가 이미 같은 경우 0 반환
        if (A.Equals(B))
        {
            return 0;
        }

        // A를 회전하며 B와 같은지 검사
        string rotated = A;
        for (int i = 1; i < A.Length; i++)
        {
            // 오른쪽으로 한 칸 회전: 마지막 문자를 앞에 붙이고 나머지 부분을 뒤에 붙임
            rotated = rotated[^1] + rotated.Substring(0, rotated.Length - 1); //tmp랑 비슷 용도

            // 회전 결과가 B와 같다면 현재 회전 횟수 i를 반환
            if (rotated.Equals(B))
            {
                return i;
            }
        }

        // 어떤 회전도 B를 만들지 못한 경우 -1 반환
        return -1;
    }
}

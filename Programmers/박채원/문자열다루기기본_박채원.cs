using System;

public class Solution
{
    public bool solution(string s)
    {
        // 문자열 길이가 4 또는 6인지 확인
        if (s.Length != 4 && s.Length != 6)
        {
            return false;
        }

        // 문자열이 숫자로만 구성되어 있는지 확인
        foreach (char c in s)
        {
            if (!Char.IsDigit(c))
            {
                return false;
            }
        }

        // 모든 조건을 만족하는 경우 true 반환
        return true;
    }
}

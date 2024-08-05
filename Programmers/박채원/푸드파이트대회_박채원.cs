using System;
using System.Text;

public class Solution
{
    public string solution(int[] food)
    {
        //stringBuilder = 문자열을 효율적으로 생성하고 조작하도록 도와주는
        StringBuilder leftSide = new StringBuilder();

        // 각 음식의 절반을 배치
        for (int i = 1; i < food.Length; i++)
        {
            int count = food[i] / 2; //음식의 가능한 최대 수 결정
            leftSide.Append(new string(char.Parse(i.ToString()), count));
        }

        // 왼쪽 배열 생성
        string leftPart = leftSide.ToString();
        // 오른쪽은 왼쪽의 역순
        string rightPart = ReverseString(leftPart);

        // 최종 배치 생성 (왼쪽 + 물 + 오른쪽)
        return leftPart + "0" + rightPart;
    }

    private string ReverseString(string s)
    {
        //입력 문자열 뒤집어 변환하여 반환

        char[] charArray = s.ToCharArray();
        //문자 배열 뒤집기
        Array.Reverse(charArray);
        //문자열 변환
        return new string(charArray);
    }
}

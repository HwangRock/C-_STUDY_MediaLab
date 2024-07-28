//2016년
using System;

public class Solution
{
    public string solution(int a, int b)
    {
        // 2016년의 각 월별 일수
        int[] daysInMonth = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        // 요일 배열 (일요일부터 토요일까지)
        string[] dayOfWeek = { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU" };

        // 1월 1일부터 해당 날짜까지의 총 일수 계산
        int day = 0;
        for (int i = 0; i < a - 1; i++)
        {
            day += daysInMonth[i];
        }
        day += (b - 1);

        // 주어진 날짜의 요일 반환
        return dayOfWeek[day % 7];
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("월과 일을 입력하세요:");
        string input = Console.ReadLine();

        //문자열을 공백 분리하여 a와 b로 변환
        string[] parts = input.Split(' ');

        if (parts.Length == 2 && int.TryParse(parts[0], out int a) && int.TryParse(parts[1], out int b))
        {
            // 결과 계산
            string result = solution.solution(a, b); //불러오는 과정에서 오류 발생
            Console.WriteLine($"2016년 {a}월 {b}일은 {result}입니다.");
        }
        else
        {
            Console.WriteLine("올바른 형식으로 입력해주세요. 예: 5 24");
        }
    }
}

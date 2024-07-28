//자연수 뒤집어 배열로 만들기
using System;

public class Solution
{
    public int[] solution(long n)
    {
        // 자연수를 문자열로 변환하여, 문자열을 뒤집고 각 문자를 숫자로 변환하여 배열로 반환
        return n.ToString()               // 자연수를 문자열로 변환
                .Reverse()                // 문자열을 뒤집기
                .Select(c => c - '0')     // 각 문자를 정수로 변환
                .ToArray();               // 배열로 변환
    }
}

class Program
{
    static void Main()
    {
        // 사용자로부터 입력받기
        Console.WriteLine("자연수를 입력하세요:");
        string input = Console.ReadLine();

        // 입력값을 long 타입으로 변환
        if (long.TryParse(input, out long n))
        {
            Solution solution = new Solution();
            int[] result = solution.solution(n);

            // 결과 출력
            Console.WriteLine("[" + string.Join(", ", result) + "]");
        }
        else
        {
            Console.WriteLine("유효한 자연수를 입력하세요.");
        }
    }
}

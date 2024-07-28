//최댓값과 최솟값
using System;

public class Solution
{
    public string solution(string s)
    {
        // 문자열을 공백 분리하여 숫자로 변환
        int[] num = s.Split(' ')               // 문자열을 공백으로 분리
                       .Select(int.Parse)        // 각 문자열을 정수로 변환
                       .ToArray();               // 배열로 변환

        // 최소값과 최대값 찾기
        int min = num.Min();
        int max = num.Max();

        // 최소값과 최대값을 문자열로 반환
        string answer = $"{min} {max}";
        return answer ;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Console.WriteLine("자연수를 입력하세요:");
        string input = Console.ReadLine();
        string result = solution.solution(input);

        Console.WriteLine(result); 
    }
}

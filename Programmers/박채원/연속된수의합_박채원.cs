using System;

public class Solution
{
    public int[] Numbers(int num, int total)
    {
        // 연속된 수열의 시작점 계산
        int start = (total - (num * (num - 1) / 2)) / num;

        // 연속된 수열 생성
        int[] result = new int[num];
        for (int i = 0; i < num; i++)
        {
            result[i] = start + i;
        }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 사용자로부터 입력 받기
        Console.Write("(num): ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("(total): ");
        int total = int.Parse(Console.ReadLine());

        // Solution 클래스의 인스턴스 생성
        Solution solution = new Solution();
        
        // 연속된 정수 배열 찾기
        int[] result = solution.Number(num, total);

        // 결과 출력
        Console.WriteLine("The consecutive numbers are:");
        Console.WriteLine(string.Join(", ", result));
    }
}

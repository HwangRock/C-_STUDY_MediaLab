namespace CS_pro2
{
    internal class Program
    {
        static void Main(String[] args)
        {
            //약수의 합
            int n = int.Parse(Console.ReadLine());
            
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

*답안
public class Solution {
    public int solution(int n) {
        
        int answer = 0;
        int sum = 0;
        
        for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
        answer = sum;
        return answer;
    }
}

namespace CS_pro2
{
    internal class Program
    {
        static void Main(String[] args)
        {
            //하샤드 수
            int n = int.Parse(Console.ReadLine());
            Solution s;
            s = new Solution();
            Console.Write(s.solution(n));
        }
    }
}
            public class Solution
        {
            public bool solution(int x)
            {
                bool answer = true;

                int sum = 0;
                int n = x;


                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }

                if (x % sum != 0)
                {
                    answer = false;
                }


                return answer;
            }
        }

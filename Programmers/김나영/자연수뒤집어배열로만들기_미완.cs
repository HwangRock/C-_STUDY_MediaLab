namespace ConsoleApp1
{
    internal class Program
    {
        public class Solution
        {
            int n = int.Parse(Console.ReadLine()); //자연수 입력받음
            int[] Narray = new int[(int)Math.log10(n) + 1]; //배열 선언

            for (int i = 0; i<Narray.length; i++) //인덱스 
                {
                Narray[i] = n % 10;
                n = n / 10;
                }
            Console.WriteLine(Narray);  
        }
    }
}

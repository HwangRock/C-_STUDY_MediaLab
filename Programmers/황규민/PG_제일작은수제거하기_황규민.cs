using System.Linq;

public class Solution
{
    public int[] solution(int[] arr)
    {
        int fin=arr.Length;
        if (fin == 1)
        {
            int[] answer = new int[1] {-1 };
            return answer;
        }
        else
        {
            int[] answer = new int[fin - 1];
            int mini = arr.Min();
            int seq = 0;
            for(int i = 0;i < fin; i++)
            {
                if (arr[i] != mini)
                {
                    answer[seq++] = arr[i];
                }
            }
            return answer;
        }
    }
}

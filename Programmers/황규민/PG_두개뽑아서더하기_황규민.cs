using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] numbers)
    {
        int[] answer = new int[] { };
        List<int> ready = new List<int>();
        int[] visit = new int[201];
        int fin=numbers.Length;
        for(int i = 0; i < fin; i++)
        {
            for (int j = i+1; j < fin; j++)
            {
                int calcul = numbers[i] + numbers[j];
                if (visit[calcul] == 0)
                {
                    ready.Add(calcul);
                    visit[calcul] = 1;
                }
            }
        }
        answer=ready.ToArray();
        Array.Sort(answer);
        return answer;
    }
}

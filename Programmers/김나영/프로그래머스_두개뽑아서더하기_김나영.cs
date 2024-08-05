using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        List<int> list = new List<int>();
        
                  for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    int sum = numbers[i] + numbers[j];
                    if (list.Contains(sum) == false) //포함X -> 넣음
                    {
                        list.Add(sum);
                    }
                }
            }
            list.Sort();
        return list.ToArray();
    }
}

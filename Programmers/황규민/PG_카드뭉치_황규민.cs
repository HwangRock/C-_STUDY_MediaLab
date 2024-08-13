using System;

public class Solution
{
    public string solution(string[] cards1, string[] cards2, string[] goal)
    {
        int ptr1 = 0, ptr2 = 0;
        int fin = goal.Length;
        for(int i = 0; i < fin; i++)
        {
            string cur = goal[i];
            if (ptr1 < cards1.Length && cards1[ptr1] == cur)
            {
                ptr1++;
            }
            else if (ptr2 < cards2.Length && cards2[ptr2] == cur)
            {
                ptr2++;
            }
            else
            {
                return "No";
            }
        }
        
        return "Yes";
    }
}

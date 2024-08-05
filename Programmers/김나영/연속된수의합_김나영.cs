
using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int num, int total) {
        
        List<int>list=new List<int>();
        int start=(total/num)-(num/2);
        int end=(total/num)+(num/2);

        if(total%num==0)
        {
            for(int i=start;i<=end;i++)
            {
                list.Add(i);
            }
        }
        else
        {
            for(int j=start+1;j<=end;j++)
            {
                list.Add(j);
            }
        }
        
        return list.ToArray();

    }
}

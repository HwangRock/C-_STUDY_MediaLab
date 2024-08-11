//읽을 필요도 없이 오류 그자체 코드

using System;

public class Solution {
    public int solution(int[] array) {
        int answer = -1;
        int target = array[0];
        int length = array.Length;
        int zunl = 0;
        int newl = 1;
        int a = 0;
        for (int i = 0; i<length; i++)
        {
            if (length==1)
            {
                break;
            }
            
            else if (array[i]!=target)
            {
                if (zunl<newl)
                {
                newl=zunl;
                a = array[i-1];
                newl = i-zunl;
                    target=array[i];
                }
            }
        }
                    if (length==1)
            {
                answer=array[0];

            }
        else if(zunl==newl)
        {
            answer=-1;
        }        
        else
        {
            answer=a;
        }
        return answer;
    }
}

using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        int a = arr[0];
        List<int> l = new List<int>();

        for(int i=0; i<arr.Length; i++)
        {
                    if(arr.Length==1) 
        {
            arr[0] = -1;
                        break;
            
        }
            if(a>arr[i]) a=arr[i];
        }      
        
        l.AddRange(arr);
        l.Remove(a);
        answer = l.ToArray();
        return answer;
    }
}

using System;
using System.Linq;

public class Solution {
    public int solution(int[] common) {
        int n = common.Length;
        
        // 등차수열인지 확인
        int diff = common[1] - common[0];
        bool isArithmetic = true;
        for (int i = 2; i < n; i++) {
            if (common[i] - common[i-1] != diff) {
                isArithmetic = false;
                break;
            }
        }
        
        if (isArithmetic) {
            // 등차수열일 경우
            return common[n-1] + diff;
        } else {
            // 등비수열일 경우
            int ratio = common[1] / common[0];
            return common[n-1] * ratio;
        }
    }
}

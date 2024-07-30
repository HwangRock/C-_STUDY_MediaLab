public class Solution {
    public long[] solution(long n) {

        string s = n.ToString();
            long[] Narray = new long[s.Length]; //배열 선언

            for (int i = 0; i < s.Length; i++) //인덱스 
            {
                Narray[i] = n % 10;
                n = n / 10;
            }

        return Narray;
    }
}

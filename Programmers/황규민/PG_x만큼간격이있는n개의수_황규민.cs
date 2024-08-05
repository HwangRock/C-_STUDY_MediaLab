public class Solution
{
    public long[] solution(int x, int n)
    {
        long[] answer = new long[n];
        int seq = 0;
        long want = x;
        while(seq<n)
        {
            answer[seq++] = want;
            want += x;
        }
        return answer;
    }
}

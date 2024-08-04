public class Solution {
    public long[] solution(int x, int n) {
        long[] answer = new long[] {};
                  for (int i = x; i <= n*x; i += x)
          {
              answer.Add(i);
          }
        return answer;
    }
}

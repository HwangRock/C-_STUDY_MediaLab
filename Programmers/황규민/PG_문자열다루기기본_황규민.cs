public class Solution
{
    public bool solution(string s)
    {
        bool answer = false;
        int str=s.Length;

        if(str == 4 || str == 6)
        {
            answer = true;
            for (int i = 0; i < str; i++)
            {
                int cur = s[i];
                if (cur > 57)
                {
                    answer = false;
                    break;
                }
            }
        }

        return answer;
    }
}

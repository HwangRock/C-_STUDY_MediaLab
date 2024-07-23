public class Solution
{
    public bool solution(int x)
    {
        bool answer = true;
        string n = x.ToString();
        int want = int.Parse(n);

        int fin = n.Length;
        int hap = 0;

        for (int i = 0; i < fin; i++)
        {
            int cur = n[i] - '0'; // 문자에서 숫자로 변환
            hap += cur;
        }

        if (want % hap == 0)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }

        return answer;
    }
}

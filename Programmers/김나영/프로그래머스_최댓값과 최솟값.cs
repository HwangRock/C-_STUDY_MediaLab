public string solution(string s)
{
    //string[] s =  Console.ReadLine().Split();
    int.Parse(s);
    int length = s.Length;

    for (int i = 0; i <= length; i++)
    { for (int j = 0; i >= 0; j--)
        {
            if (s[j - 1] > s[j])
            {
                s[j], s[j - 1] = s[j - 1], s[j]; //오류
            }
        }
    }

    string answer = s[0] + "" + s[length - 1];
    return answer;
}

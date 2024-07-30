int[] visit = new int[10001];
int size = 0;

int hap(int k)
{
    int ans = 0;
    string s = k.ToString();
    int fin = s.Length;
    for(int i = 0; i < fin; i++)
    {
        int cur = s[i] - '0';
        ans += cur;
    }
    ans += k;
    return ans;
}

for(int i = 1; i <= 10000; i++)
{
    int num = hap(i);
    if (num > 10000)
    {
        continue;
    }
    if (visit[num] == 0)
    {
        visit[num] = 1;
        size += 1;
    }
}

for(int i = 1; i < 10000; i++)
{
    if (visit[i] == 0)
    {
        Console.WriteLine(i);
    }
}

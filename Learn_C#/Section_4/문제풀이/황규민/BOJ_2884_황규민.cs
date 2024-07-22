string[] num = Console.ReadLine().Split();

int h = int.Parse(num[0]);
int m = int.Parse(num[1]);

if (m <= 44)
{
    if (h == 0)
    {
        h = 23;
    }
    else
    {
        h -= 1;
    }
    m = m + (60 - 45);
}
else
{
    m -= 45;
}
Console.WriteLine(h + " " + m);


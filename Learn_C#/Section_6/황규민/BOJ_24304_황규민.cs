int cost = int.Parse(Console.ReadLine());
int t = int.Parse(Console.ReadLine());

int hap = 0;

for (int i = 1; i <= t; i++)
{
    string[] num = Console.ReadLine().Split();
    int num1 = int.Parse(num[0]);
    int num2 = int.Parse(num[1]);
    hap += num1 * num2;
}
if (hap == cost)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}


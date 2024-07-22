int t = int.Parse(Console.ReadLine());

for(int i = 0; i < t; i++)
{
    string[] num = Console.ReadLine().Split();
    int n1 = int.Parse(num[0]);
    int n2 = int.Parse(num[1]);
    Console.WriteLine(n1 + n2);
}

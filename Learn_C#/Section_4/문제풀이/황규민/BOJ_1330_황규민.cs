string[] num = Console.ReadLine().Split();

int num1 = int.Parse(num[0]);
int num2 = int.Parse(num[1]);


if (num1 == num2)
{
    Console.WriteLine("==");
}
else
{
    if (num1 > num2)
    {
        Console.WriteLine(">");
    }
    else
    {
        Console.WriteLine("<");
    }
}

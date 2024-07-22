string[] num = Console.ReadLine().Split();
int interval = int.Parse(Console.ReadLine());

int h = int.Parse(num[0]);
int m = int.Parse(num[1]);

int new_hour = (h + (m + interval) / 60) % 24;
m = (m + interval) % 60;

Console.WriteLine(new_hour + " " + m);

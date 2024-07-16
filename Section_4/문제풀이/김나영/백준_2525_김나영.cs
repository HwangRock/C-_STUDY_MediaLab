namespace 조건
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] now_time = Console.ReadLine().Split();
            int need_time = int.Parse(Console.ReadLine());

            int now_T = int.Parse(now_time[0]);
            int now_M = int.Parse(now_time[1]);

            if (now_M + need_time < 60) { now_M += need_time; }
            else if (now_M + need_time >= 60)
            {
                now_T += ((now_M + need_time) / 60);
                now_M = (now_M+need_time) % 60;
            }
            if (now_T >= 24)
            { now_T = now_T % 24; }

            Console.WriteLine(now_T + " " + now_M);
        }
    }
}

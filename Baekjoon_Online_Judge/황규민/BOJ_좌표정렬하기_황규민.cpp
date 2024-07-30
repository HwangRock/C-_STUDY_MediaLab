//문제가 시간초과 나기가 쉬워서 C#이나 C++로는 통과하기 어려워서 C의 입출력을 사용.
//밑에 시간초과난 C#코드도 있음.

#include<stdio.h>
#include<algorithm>
#include<vector>
using namespace std;

pair<int,int>p; //2개의 변수를 저장할 수 있는 pair
bool compare(pair<int, int>a, pair<int, int>b) {//pair
        if (a.first == b.first) {
            return a.second < b.second;
        }
        else {
            return a.first < b.first;
        }
}
int N;
int x, y;

int main(void) {
    vector<pair<int, int>>num;
    scanf("%d",&N);//좌표의 개수
    for (int i = 0; i < N; i++) {
        scanf("%d %d", &x, &y);
        num.push_back(make_pair(x, y));
    }

    sort(num.begin(), num.end(), compare);

    for (int i = 0; i < N; i++) {
        printf("%d %d\n",num[i].first, num[i].second);
    }
}

/*
시간초과 발생한 C# 코드

class Program
{
    static int sorting(Tuple<int, int> a, Tuple<int, int> b)
    {
        if (a.Item1 == b.Item1)
        {
            return a.Item2.CompareTo(b.Item2);
        }
        else
        {
            return a.Item1.CompareTo(b.Item1);
        }
    }

    static void Main()
    {
        List<Tuple<int, int>> num = new List<Tuple<int, int>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            num.Add(new Tuple<int, int>(x, y));
        }

        num.Sort(sorting);


        for(int i=0;i<n;i++)
        {
            Console.WriteLine($"{num[i].Item1} {num[i].Item2}");
        }
    }
}

*/

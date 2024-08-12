#include <string>
#include <vector>

using namespace std;
int fib(long long n) {
    vector<long long> f;
    //int res;

    //찾아서 꺼내 쓰기
    f.push_back(0); //f[0]
    f.push_back(1); //f[1]

    if (n < 2)  return n;
    else {
        for (long long i = 2; i <= n; i++) {
            //오버플로우 나서 함수 안에서 직접 계산
            f.push_back((f[i - 1] + f[i - 2]) % 1234567);
        }
    }

    return f[n];
}
int solution(int n) {
    long long answer = 0;
    //피보나치 수
    answer = fib(n) % 1234567;
    return answer;
}



////////////////
////C++풀이////
///////////////

/*
#define _CRT_SECURE_NO_WARNINGS
#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

#include <queue>
#include <map>
#include <stdio.h>

using namespace std;



int fib(long long n) {
    vector<long long> f;
    //int res;

    //찾아서 꺼내 쓰기
    f.push_back(0); //f[0]
    f.push_back(1); //f[1]

    if (n < 2)  return n;
    else {
        for (long long i = 2; i <= n; i++) {
            //오버플로우 나서 함수 안에서 직접 계산
            f.push_back((f[i - 1] + f[i - 2]) % 1234567);
        }
    }

    return f[n];
}

int main(int argc, char const* argv[])
{
   //피보나치 수
    //재귀함수로 했더니 시간초과가..
    //계산 값을 저장해서 필요할 때 호출

    long long n = 5;
    long long answer = 0;

    answer = fib(n);
    
    cout << answer;

    return 0;
}

*/

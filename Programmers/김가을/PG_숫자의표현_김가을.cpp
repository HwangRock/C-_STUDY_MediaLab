#include <string>
#include <vector>

using namespace std;

int solution(int n) {
    int answer = 0;
    for (int i = 1; i <= n; i++) { //시작 숫자  결정
        int sum = 0;
        for (int j = i; j <= n; j++) { //더하기
            sum += j;
            if (sum == n) {
                answer++; break;
            }
            else if (sum > n) break;
        }
    }
    return answer;
}


///////////////////////////
//////////C++풀이//////////
//////////////////////////

/*

#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

#include <map>

using namespace std;


int main(int argc, char const* argv[])
{
    //숫자의 표현

    int n = 15;
    int answer = 0;

    for (int i = 1; i <= n; i++) { //시작 숫자  결정
        int sum = 0;
        for (int j = i; j <= n; j++) { //더하기
            sum += j;
            if (sum == n) {
                answer++; break;
            }
            else if (sum > n) break;
        }
    }

    cout << answer;
    return 0;
}


*/

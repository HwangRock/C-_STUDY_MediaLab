#include <iostream>
#include <stdio.h>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int solution(vector<int> d, int budget) {
    int answer = 0;
     //가장 많은 숫자만큼 지원 -> 작은 것부터 오름차순 정렬
    sort(d.begin(), d.end());

    for (int i = 0; i < d.size(); i++) {
        if (budget - d[i] >= 0) {
            budget -= d[i];
            answer++;
        }
        else break;
    }

    return answer;
}


////////////////////////////
//////////C++ 풀이//////////
///////////////////////////

/*

#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

#include <map>

using namespace std;


int main(int argc, char const* argv[])
{
    //예산 

    vector<int> d;
    d.push_back(1);
    d.push_back(3);
    d.push_back(2);
    d.push_back(5);
    d.push_back(4);

    int budget = 9;
    int answer = 0;

    //가장 많은 숫자만큼 지원 -> 작은 것부터 오름차순 정렬
    sort(d.begin(), d.end());

    for (int i = 0; i < d.size(); i++) {
        if (budget - d[i] >= 0) {
            budget -= d[i];
            answer++;
        }
        else break;
    }

    cout << answer;
    return 0;
}
*/

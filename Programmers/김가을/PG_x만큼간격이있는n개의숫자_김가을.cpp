#include <string>
#include <vector>

using namespace std;

vector<long long> solution(int x, int n) {
    vector<long long> answer;
    int xx = 0;

    for (int i = 0; i < n; i++) {
        xx += x;
        answer.push_back(xx);
    }
    return answer;
}


///////////////////////////
//////////C++코드//////////
//////////////////////////
/*
#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;

int main(int argc, char const* argv[])
{
    //int x = 2, n = 5;
    int xx = 0;
    vector<long long> answer;

    for (int i = 0; i < n; i++) {
        xx += x;
        answer.push_back(xx);
    }

    return 0;
}

*/

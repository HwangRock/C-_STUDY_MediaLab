#include <string>
#include <vector>

using namespace std;

vector<int> solution(int num, int total) {
    vector<int> answer;
    int  sum = 0, middle = 0, first = 0;
    //num 6 total 21 : 1+2+3+4+5+6 
    //num 4 total 10 : 1+2+3+4
    //num 짝수면 : ((num + total) / num ) - 1 이 가운데 앞쪽
    //num 홀수면 : ((num + total) / num ) - 1 이 가운데

    middle = ((num + total) / num) - 1;

    //짝수일때
    if (num % 2 == 0) {
        //앞 간격 : 
        first = middle - (num / 2 - 1);
    }
    //홀수일때
    else {
        //앞 간격 : num / 2
        first = middle - num / 2;
    }

    for (int i = 0; i < num; i++) { answer.push_back(first + i); }

    return answer;
}



//////////////////////////////
/////////C++ 파일/////////////
//////////////////////////////

/*
#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;

int main(int argc, char const* argv[])
{
    vector<int> answer;
    int num, total, sum = 0, middle = 0, first = 0;
    //num 6 total 21 : 1+2+3+4+5+6 
    //num 4 total 10 : 1+2+3+4
    //num 짝수면 : ((num + total) / num ) - 1 이 가운데 앞쪽
    //num 홀수면 : ((num + total) / num ) - 1 이 가운데

    middle = ((num + total) / num) - 1;

    //짝수일때
    if (num % 2 == 0) {
        //앞 간격 : 
        first = middle - (num / 2 - 1);
    }
    //홀수일때
    else {
        //앞 간격 : num / 2
        first = middle - num / 2;
    }

    for (int i = 0; i < num; i++) { answer.push_back(first + i); }

    return 0;
}
*/

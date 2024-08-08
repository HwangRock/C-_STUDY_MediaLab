#include <string>
#include <vector>

using namespace std;

int solution(string t, string p) {
    int answer = 0;
     int plen = p.length(), tlen = t.length();
    string tmp;
    long long p_i, tmp_i; //core dumped 오류 해결하기 위해 큰 자료형으로..

    for (int i = 0; i <= tlen - plen; i++) {
        tmp = t.substr(i, plen); //문자열 자르기
        tmp_i = stoll(tmp), p_i = stoll(p);
        if (tmp_i <= p_i) {
            answer++;
        }
    }
    return answer;
}


////////////////////
//////////C++풀이///
///////////////////

/*

#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;


int main(int argc, char const* argv[])
{
    string t = "500220839878", p = "7";
    int answer = 0;

    int plen = p.length(), tlen = t.length();
    string tmp;
    long long p_i, tmp_i; //core dumped 오류 해결하기 위해 큰 자료형으로..

    for (int i = 0; i <= tlen - plen; i++) {
        tmp = t.substr(i, plen); //문자열 자르기
        tmp_i = stoll(tmp), p_i = stoll(p);
        if (tmp_i <= p_i) {
            answer++;
        }
    }

    cout << answer;
    return 0;
}

*/

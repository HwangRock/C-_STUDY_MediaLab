#include <string>
#include <vector>

using namespace std;

int solution(vector<int> common) {
    int answer = 0;
    //등차일 경우 : 인덱스 값의 차가 같음
    if (common[1] - common[0] == common[2] - common[1]) {
        answer = common[common.size() - 1] + common[1] - common[0];
    }
    else 
        answer = common[common.size() - 1] * (common[1] / common[0]);

    return answer;
}



////////////////////////////
//////////C++풀이///////////
///////////////////////////

/*

#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;


int main(int argc, char const* argv[])
{
    //다음에 올 숫자

    vector<int> common;
    common.push_back(1);
    common.push_back(2);
    common.push_back(3);
    common.push_back(4);
    int answer = 0;
    
    //등차일 경우 : 인덱스 값의 차가 같음
    if (common[1] - common[0] == common[2] - common[1]) {
        answer = common[common.size() - 1] + common[1] - common[0];
    }
    else 
        answer = common[common.size() - 1] * (common[1] / common[0]);

    cout << answer;

    return 0;
}

*/

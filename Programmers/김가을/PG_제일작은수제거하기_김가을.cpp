#include <string>
#include <vector>
#include <algorithm>
#include <iostream>
using namespace std;

vector<int> solution(vector<int> arr) {
    //제일 작은 수 제거하기
    vector<int> answer;

    //최솟값 인덱스
    int min_i = min_element(arr.begin(), arr.end()) - arr.begin();
    arr.erase(arr.begin() + min_i);

    for (int i = 0; i < arr.size(); i++) {
        answer.push_back(arr[i]);
    }
    if (answer.empty()) answer.push_back(-1);

    for (int i = 0; i < answer.size(); i++) {
        cout << answer[i];
    }
    return answer;
}



//////////////////////////////
///////////C++ 파일///////////
/////////////////////////////


/*
#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;

int main(int argc, char const* argv[])
{
   //제일 작은 수 제거하기
    vector<int> arr;
    vector<int> answer;

    //최솟값 인덱스
    int min_i = min_element(arr.begin(), arr.end()) - arr.begin();
    arr.erase(arr.begin() + min_i);

    for (int i = 0; i < arr.size(); i++) {
        answer.push_back(arr[i]);
    }
    if (answer.empty()) answer.push_back(-1);

    for (int i = 0; i < answer.size(); i++) {
        cout << answer[i];
    }
    


    return 0;
}

*/

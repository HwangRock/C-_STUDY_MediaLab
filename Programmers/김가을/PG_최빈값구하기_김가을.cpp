
#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

#include <map>

using namespace std;

int solution(vector<int> array) {
    int answer = 0;
    int max_count = 0; //최대 빈도
    map<int, int> freq; // 각 숫자 빈도 저장

    for(int i:array) {
        freq[i]++;
        if (freq[i] > max_count) {
            max_count = freq[i];//현재 숫자 빈도를 저장
            answer = i;
        }
        else if (freq[i] == max_count) answer = -1;
    }

    return answer;
}



/////////////////////
/////C++ 풀이////////
////////////////////

/*
#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

#include <map>

using namespace std;


int main(int argc, char const* argv[])
{
        //최빈값 구하기

    vector<int> array;
    array.push_back(1);
    array.push_back(2);
    array.push_back(3);
    array.push_back(3);
    array.push_back(3);
    array.push_back(4);

    int answer = 0;
    int max_count = 0; //최대 빈도
    map<int, int> freq; // 각 숫자 빈도 저장

    for(int i:array) {
        freq[i]++;
        if (freq[i] > max_count) { 
            max_count = freq[i]; //현재 숫자 빈도를 저장
            answer = i;
        }
        else if (freq[i] == max_count) answer = -1;
    }

    cout << answer;
    return 0;
}
*/

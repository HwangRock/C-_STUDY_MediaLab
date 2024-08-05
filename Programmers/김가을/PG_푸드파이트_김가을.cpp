#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;

string solution(vector<int> food) {
    string answer = "";
     string tmp = "";
 //홀수개면 몫만 남음.

 for (int i = 1; i < food.size(); i++) {
     int c = food[i] / 2; //한쪽 개수
     
     if (c > 0) {
         for (int j = 0; j < c; j++) {
             answer += to_string(i);

         }
     }
 }
 tmp = answer;
 reverse(tmp.begin(), tmp.end());
 answer = answer + "0" + tmp;
    
    return answer;
}

///////////////////
///////C++풀이/////
//////////////////

/*
#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;

int main(int argc, char const* argv[])
{
    //푸드 파이트 대회

    //인덱스 0 : 물 . 1부터 음식

    vector<int> food;
    food.push_back(1);
    food.push_back(3);
    food.push_back(4);
    food.push_back(6);
    string answer = "";
    string tmp = "";
    //홀수개면 몫만 남음.

    for (int i = 1; i < food.size(); i++) {
        int c = food[i] / 2; //한쪽 개수
        
        if (c > 0) {
            for (int j = 0; j < c; j++) {
                answer += to_string(i);

            }
        }
    }
    tmp = answer;
    reverse(tmp.begin(), tmp.end());
    answer = answer + "0" + tmp;
    cout << answer;
    
    return 0;
}

*/

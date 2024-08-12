#include <string>
#include <vector>

using namespace std;

int solution(vector<vector<int>> dots) {
    int answer = 0;
    //기울기가 같으면 평행 -> 모든 케이스 비교
    //나누기 대신 곱하기(정밀도 문제)
    
    // 모든 조합을 비교하여 평행 여부 확인
    // (0, 1)과 (2, 3) 비교
    if ((dots[0][1] - dots[1][1]) * (dots[2][0] - dots[3][0]) == (dots[2][1] - dots[3][1]) * (dots[0][0] - dots[1][0])) {
        answer = 1;
    }

    // (0, 2)와 (1, 3) 비교
    if ((dots[0][1] - dots[2][1]) * (dots[1][0] - dots[3][0]) == (dots[1][1] - dots[3][1]) * (dots[0][0] - dots[2][0])) {
        answer = 1;
    }

    // (0, 3)와 (1, 2) 비교
    if ((dots[0][1] - dots[3][1]) * (dots[1][0] - dots[2][0]) == (dots[1][1] - dots[2][1]) * (dots[0][0] - dots[3][0])) {
        answer = 1;
    }
    return answer;
}


/////////////////////////////
///////////C++풀이//////////
////////////////////////////

/*
#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

#include <map>
#include <stdio.h>

using namespace std;



int main(int argc, char const* argv[])
{
    vector<vector<int>> dots;
    dots.push_back({ 1, 4 });
    dots.push_back({ 9, 2 });
    dots.push_back({ 3, 8 });
    dots.push_back({ 11, 6 });
    int answer = 0;

    //기울기가 같으면 평행 -> 모든 케이스 비교
    //나누기 대신 곱하기(정밀도 문제)

    // 모든 조합을 비교하여 평행 여부 확인
    // (0, 1)과 (2, 3) 비교
    if ((dots[0][1] - dots[1][1]) * (dots[2][0] - dots[3][0]) == (dots[2][1] - dots[3][1]) * (dots[0][0] - dots[1][0])) {
        answer = 1;
    }

    // (0, 2)와 (1, 3) 비교
    if ((dots[0][1] - dots[2][1]) * (dots[1][0] - dots[3][0]) == (dots[1][1] - dots[3][1]) * (dots[0][0] - dots[2][0])) {
        answer = 1;
    }

    // (0, 3)와 (1, 2) 비교
    if ((dots[0][1] - dots[3][1]) * (dots[1][0] - dots[2][0]) == (dots[1][1] - dots[2][1]) * (dots[0][0] - dots[3][0])) {
        answer = 1;
    }
    cout << answer;

    return 0;
}
*/

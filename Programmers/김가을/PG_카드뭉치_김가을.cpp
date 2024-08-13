// 실행창은 통과했지만 제출 시 몇 문제 오류
#include <string>
#include <vector>
#include <queue>

using namespace std;

string solution(vector<string> cards1, vector<string> cards2, vector<string> goal) {

    string answer = "Yes";

    //goal과 큐의 앞 값을 비교

    queue<string> q1, q2;
    string q1_f, q2_f; //front 값 저장
    bool able = false;

    for (const auto& s : cards1) {
        q1.push(s);
    }

    for (const auto& s : cards2) {
        q2.push(s);
    }

    for (const auto& g : goal) {
        able = false;

        q1_f = q1.front();
        q2_f = q2.front();


        if (!q1.empty() && (g == q1_f)) {
            able = true;
            q1.pop();
        }else if (!q2.empty() && (g == q2_f)) {
            able = true;
            q2.pop();
        }
        if (!able) { answer = "No";  break; }
    }
    
    if (able) answer = "Yes";
    return answer;
}


/*


#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

#include <queue>
#include <map>
#include <stdio.h>

using namespace std;



int main(int argc, char const* argv[])
{
    //카드 뭉치
    vector<string> cards1;
    vector<string> cards2;
    vector<string> goal;

    cards1.push_back("i");
    cards1.push_back("water");
    cards1.push_back("drink");

    cards2.push_back("want");
    cards2.push_back("to");

    goal.push_back("i");
    goal.push_back("want");
    goal.push_back("to");
    goal.push_back("drink");
    goal.push_back("water");

    string answer = "Yes";

    //goal과 큐의 앞 값을 비교

    queue<string> q1, q2;
    string q1_f, q2_f; //front 값 저장
    bool able = false;

    for (const auto& s : cards1) {
        q1.push(s);
    }

    for (const auto& s : cards2) {
        q2.push(s);
    }

    for (const auto& g : goal) {
        able = false;

        q1_f = q1.front();
        q2_f = q2.front();


        if (!q1.empty() && (g == q1_f)) {
            able = true;
            q1.pop();
        }else if (!q1.empty() && (g == q2_f)) {
            able = true;
            q2.pop();
        }
        if (!able) { answer = "No";  break; }
    }
    
    if (able) answer = "Yes";
    

    cout << answer;
    

    return 0;
}

*/

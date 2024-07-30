#include<iostream>
#include <vector>
#include <stack>
#include<algorithm>

using namespace std;

vector<int> solution(vector<int> arr){
    vector<int> answer;
    stack<int>s;
    int fin = arr.size();
    for (int i = 0; i < fin; i++) {
        int cur = arr[i];
        if (!i) {
            s.push(cur);
        }
        else {
            int before = s.top();
            if (before != cur) {
                s.push(cur);
            }
        }
    }
    while (!s.empty()) {
        int cur = s.top();
        s.pop();
        answer.push_back(cur);
    }
    reverse(answer.begin(), answer.end());
    return answer;
}

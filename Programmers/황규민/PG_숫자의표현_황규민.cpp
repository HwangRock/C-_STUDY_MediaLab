#include <iostream>

using namespace std;
#define full 10001
int num[full];

int solution(int n) {
    int answer = 0;
    int calcul = 1;
    for (int i = 1; i <= n; i++) {
        num[i] = i;
    }
    int start = 1, end = 1;
    while (1) {
        if (calcul <= n) {
            if (calcul == n) {
                //cout << start << " " << end << "\n";
                answer++;
            }
            if (end < n) {
                end++;
                calcul += num[end];
            }
        }
        else {
            calcul -= num[start];
            start++;
        }
        if (end == n) {
            break;
        }
    }
    if (start == end) {
        return answer;
    }
    else {
        return answer + 1;
    }
}

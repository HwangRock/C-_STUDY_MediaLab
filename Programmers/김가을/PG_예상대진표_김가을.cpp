#include <iostream>

using namespace std;

int solution(int n, int a, int b) {
    //1: a = 2, b = 4, round = 1
    //2: a = 1, b = 2, round = 2
    //3: a = 1, b = 1, round = 3 -> 같은 그룹임
    
    int round = 0;
    while (a != b) {
        a = (a + 1) / 2;
        b = (b + 1) / 2;
        round++;
    }
    return round;
}

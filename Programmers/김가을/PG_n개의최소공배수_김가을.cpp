#include <string>
#include <vector>

using namespace std;
int GCD(int a, int b) {
    if (a % b == 0) return b;
    return GCD(b, a % b);
}

int LCM(int a, int b) {
    return a * b / GCD(a, b);
}

int solution(vector<int> arr) {
    int answer = 0;
    //n개의 최소공배수

//최소공배수 = (A*B) / 최대공약수
//최대공약수 : 유클리드 호제법 : 큰 수 % 작은 수....계속 비교
//lcm : 최소공배수, gcd : 최대공약수

answer = arr[0];

for (int i = 1; i < arr.size(); i++) {
    
    answer = LCM(answer, arr[i]);
}
    return answer;
}



///////////////////////////////////
///////////////C++풀이/////////////
//////////////////////////////////

/*
#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;

int GCD(int a, int b) {
    if (a % b == 0) return b;
    return GCD(b, a % b);
}

int LCM(int a, int b) {
    return a * b / GCD(a, b);
}

int main(int argc, char const* argv[])
{
    //n개의 최소공배수

    //최소공배수 = (A*B) / 최대공약수
    //최대공약수 : 유클리드 호제법 : 큰 수 % 작은 수....계속 비교
    vector<int> arr;
    arr.push_back(2);
    arr.push_back(6);
    arr.push_back(8);
    arr.push_back(14);
    
    int answer = 0; //lcm : 최소공배수, gcd : 최대공약수
    
    answer = arr[0];

    for (int i = 1; i < arr.size(); i++) {
        
        answer = LCM(answer, arr[i]);
    }
    cout << answer;
    return 0;
}
*/

#include <string>
#include <vector>

using namespace std;

int solution(string A, string B) {
    string tmp = "";
    int answer = 0;
    bool able = true;

    for (int i = 0; i < A.length(); i++) {
        if (A == B) {
            break;
        }

        tmp = A[A.length() - 1];
        A = tmp + A;
        A.erase(A.size() - 1);
        answer++;
        
    }
    if (answer == A.length()) {
        answer = -1;
    }
    
    
    return answer;
}

//////////////////////////
/////////C++ 파일/////////
/////////////////////////

/*
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;

int main(int argc, char const* argv[])
{
    //문자열 밀기

    //string A = "abc", B = "abc";
    string tmp = "";
    int answer = 0;
    bool able = true;

    for (int i = 0; i < A.length(); i++) {
        if (A == B) {
            break;
        }

        tmp = A[A.length() - 1];
        A = tmp + A;
        A.erase(A.size() - 1);
        answer++;
        
    }
    if (answer == A.length()) {
        answer = -1;
    }
    
    cout << answer;
    

    return 0;
}
*/

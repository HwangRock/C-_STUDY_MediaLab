#include <string>
#include <vector>
#include <iostream>
#include <algorithm>
#include <stack>

using namespace std;



int main(int argc, char* argv[]) {
    int answer = 0, count = 0;
    bool status, a = true; //올바른 괄호인지?
    stack<char> stack;
    string s = "[](){}"; // ](){}[ (){}[] ){}[]( {}[]() }[](){ 
    int len = s.length();
    string tmp_s = "";

    //괄호 쌍 확인 : 스택
    //여는 괄호 : 스택에 push  / 닫는 괄호 : 스택 top 값과 비교
    for (char c : s) {
        switch(c){
        case '(': case '[': case '{':
            stack.push(c); break;

        case ')': case ']': case '}':
            if (stack.empty()) {
                status = false;
                a = false;
            }
            else { 
                char top = stack.top();
                stack.pop();
                if ((c == ')' && top != '(') ||
                    (c == ']' && top != '[') ||
                    (c == '}' && top != '{')) {
                    status = false;
                }
            }
        }
        
    }

    //스택이 비어있으면 올바른 괄호
    if (a) {
        if (stack.empty()) { 
            status = true;
            answer++;
        }
        else {
            status = false;
        }
    }
    
    cout << answer << endl;


    //괄호 회전 : 큐....안쓰고 걍 앞뒤글자만 바꾸기
    
    
    while (count <= len ) {
        char tmp = s.front();
        for (int i = 0; i < len; i++) {
            s[i] = s[i + 1];
        }
        s.back() = tmp;
        count++;

        cout << s << endl;
        

    }

    cout << answer << endl;


    return 0;
}

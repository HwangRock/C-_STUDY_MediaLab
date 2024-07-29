#include <string>
#include <vector>
#include <stack>
#include <iostream>


using namespace std;

bool solution(string s)
{
    bool answer = false;
    bool status = false;

    stack<char> stack;
    //string s = "[](){}"; // ](){}[ (){}[] ){}[]( {}[]() }[](){ 
    int len = s.length();
    string tmp_s = "";
    char top;

//괄호 쌍 확인 : 스택
//여는 괄호 : 스택에 push  / 닫는 괄호 : 스택 top 값과 비교

        status = false;
      //  cout << s << endl;
    for (char c : s) {
        top = ' ';
        switch (c) {
        case '(': case '[': case '{':
            stack.push(c); break;

        case ')': case ']': case '}':
            if (stack.empty()) {
                status = false;
                break;
            }
                if(s[0] == ')') {answer = false; break;}
            else {
                top = stack.top();
                
                if ((c == ')' && top == '(') ||
                    (c == ']' && top == '[') ||
                    (c == '}' && top == '{')) {
                    stack.pop();
                    status = true;
                    break;
                }
                
            }
        }

    }
    
    //스택이 비어있으면 올바른 괄호
    if (stack.empty() && status) {
        answer = true;
    }
    else if (!(stack.empty())) {
        while (!(stack.empty())) {
            stack.pop();
        }
    }
    
    
    
    // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
    cout << answer << endl;

    return answer;
}

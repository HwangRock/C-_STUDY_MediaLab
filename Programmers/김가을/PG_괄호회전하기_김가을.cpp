#include <string>
#include <vector>
#include <iostream>
#include <algorithm>
#include <stack>

using namespace std;



int main(int argc, char* argv[]) {
    int answer = 0;
    bool status = false; //올바른 괄호인지?
    stack<char> stack;
    string s = "[](){}"; // ](){}[ (){}[] ){}[]( {}[]() }[](){ 
    int len = s.length();
    string tmp_s = "";
    char top;

    //괄호 쌍 확인 : 스택
    //여는 괄호 : 스택에 push  / 닫는 괄호 : 스택 top 값과 비교
        for (int i = 0; i < s.length(); i++) {
            status = false;
            cout << s << endl;
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
            answer++;
        }
        else if (!(stack.empty())) {
            while (!(stack.empty())) {
                stack.pop();
            }
        }
        


        //괄호 회전 : 큐....안쓰고 걍 앞뒤글자만 바꾸기


        char tmp = s.front();
        s.erase(s.begin());
        s.push_back(tmp);

        
    }

    cout << answer << endl;


    return 0;
}


















///////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////프로그래머스 제출///////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////



/*
#include <string>
#include <vector>
#include <stack>
#include <iostream>

using namespace std;

int solution(string s) {
    int answer = 0;
bool status = false; //올바른 괄호인지?
stack<char> stack;
//string s = "[](){}"; // ](){}[ (){}[] ){}[]( {}[]() }[](){ 
int len = s.length();
string tmp_s = "";
char top;

//괄호 쌍 확인 : 스택
//여는 괄호 : 스택에 push  / 닫는 괄호 : 스택 top 값과 비교
    for (int i = 0; i < s.length(); i++) {
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
        answer++;
    }
    else if (!(stack.empty())) {
        while (!(stack.empty())) {
            stack.pop();
        }
    }
    


    //괄호 회전 : 큐....안쓰고 걍 앞뒤글자만 바꾸기


    char tmp = s.front();
    s.erase(s.begin());
    s.push_back(tmp);

    
}
    return answer;
}
*/

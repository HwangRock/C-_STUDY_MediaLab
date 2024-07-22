#include <string>
#include <stack>

using namespace std;

int solution(string n) {
    int ans = 0;
    stack<char>s;
    int fin = n.length();
    for (int j = 0; j < fin; j++) {
        bool able = false;
        for (int i = 0; i < fin; i++) {
            char cur = n[i];
            char frt = ' ';
            if (!s.empty()) {
                frt = s.top();
            }
            if (cur == '(' or cur == '{' or cur == '[') {
                s.push(cur);
            }
            else {
                if (cur == ')' and frt == '(') {
                    s.pop();
                    able = true;
                }
                else if (cur == ']' and frt == '[') {
                    s.pop();
                    able = true;
                }
                else if (cur == '}' and frt == '{') {
                    s.pop();
                    able = true;
                }
            }
        }
        if (s.empty() and able) {
            ans++;
        }
        else if(!s.empty()) {
            while (!s.empty()) {
                s.pop();
            }
        }
        char str = n[0];
        n.erase(n.begin());
        n.push_back(str);
    }
    return ans;
}

#include <string>
#include <vector>

using namespace std;

bool solution(string s) {
     
bool answer = true;

    if ((s.length() == 4) or (s.length() == 6)) {
        answer = true; 

        for (int i = 0; i < s.length(); i++) {
            if (!isdigit(s[i])) {
                answer = false; break;
            }
        }
    }

    else {
        answer = false;
    }
    return answer;
}



/////////////////////////
///////////////C++풀이///
////////////////////////

/*
#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;


int main(int argc, char const* argv[])
{
    string s = "000000";
    bool answer = true;

    if ((s.length() == 4) or (s.length() == 6)) {
        answer = true; 
        for (int i = 0; i < s.length(); i++) {
            if (!isdigit(s[i])) {
                answer = false; break;
            }
        }
    }

    else {
        answer = false;
    }

    cout << answer;
    return 0;
}
*/

#include <string>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

int main(int argc, char* argv[]) {
    vector<int> answer;
    string st = "110010101001";
    string tmp_st, ans_st;
    int count = 0, count_zero = 0, tmp_zero = 0, l = 0;
    
    while (st != "1") {
        tmp_st = "", ans_st = "";

        //글자 수만큼 반복, 제거된 0 개수 추가
        for (char c : st) {
            if (c == '0') {
                tmp_zero++; 
            }
        }

        //모든 0 제거하여 tmp_st에 1만 있는 문자열 생성
        for (int i = 0; i < st.length() - tmp_zero; i++) {
            tmp_st += "1";
        }

        //1만 있는 문자열 길이를 2진법으로 전환
        l = tmp_st.length();
        while (l > 0) {
            ans_st += to_string(l % 2);
            l /= 2;
        }

        //낮은 자리부터 추가했기 때문에 reverse
        reverse(ans_st.begin(), ans_st.end());
        
        //이진 변환한 횟수 추가
        count++;

        //count_zero에 제거된 0 개수 누적
        count_zero += tmp_zero;
        
        //변수 초기화
        tmp_zero = 0;
        st = ans_st;
    }

    //answer 벡터에 원소 추가(변환 횟수, 제거된 0 개수)
    answer.push_back(count);
    answer.push_back(count_zero);

    std::cout << answer[0] <<  " " << answer[1] << endl;

    return 0;
}














///////////////////////////////////////////////////////////////////////////////
//////////////////////////프로그래머스 답//////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////

/*
#include <string>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

vector<int> solution(string st) {
    vector<int> answer;
        string tmp_st, ans_st;
    int count = 0, count_zero = 0, tmp_zero = 0, l = 0;
    
    while (st != "1") {

        tmp_st = "", ans_st = "";

        //글자 수만큼 반복, 제거된 0 개수 추가
        for (char c : st) {
            if (c == '0') {
                tmp_zero++; 
            }
        }

        //모든 0 제거하여 tmp_st에 1만 있는 문자열 생성
        for (int i = 0; i < st.length() - tmp_zero; i++) {
            tmp_st += "1";
        }


        //1만 있는 문자열 길이를 2진법으로 전환
        l = tmp_st.length();
        while (l > 0) {
            ans_st += to_string(l % 2);
            l /= 2;
        }

        //낮은 자리부터 추가했기 때문에 reverse
        reverse(ans_st.begin(), ans_st.end());


        //이진 변환한 횟수 추가
        count++;


        //count_zero에 제거된 0 개수 누적
        count_zero += tmp_zero;
        
        //변수 초기화
        tmp_zero = 0;
        st = ans_st;
    }

    //answer 벡터에 원소 추가(변환 횟수, 제거된 0 개수)
    answer.push_back(count);
    answer.push_back(count_zero);
    
    return answer;
}
*/

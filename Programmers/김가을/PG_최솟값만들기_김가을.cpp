#include <vector>
#include <string>
#include <algorithm>
#include <iostream>
using namespace std;

int solution(vector<int> A, vector<int> B)
{
    int answer = 0, last_sum = 0, tmp = 0, sum = 0;
    
    //첫 배열 : 오름차순 , 두번째 배열 : 내림차순 정렬
    sort(A.begin(), A.end());
    sort(B.begin(), B.end(), greater<int>());

    for (int i = 0; i < A.size(); i++) {
        sum = A[i] * B[i];
        answer += sum;
        sum = 0;
    }

    cout << answer << endl;
    return answer;
}


//////////////////////////////////////
/////////////C++코드//////////////////
//////////////////////////////////////

/*

#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;


int main(int argc, char const* argv[])
{
    vector<int> A;
    vector<int> B;

   /* A.push_back(1);
    A.push_back(4);
    A.push_back(2);

    B.push_back(5);
    B.push_back(4);
    B.push_back(4);*/

    int answer = 0, last_sum = 0, tmp = 0, sum = 0;
    
    //첫 배열 : 오름차순 , 두번째 배열 : 내림차순 정렬
    sort(A.begin(), A.end());
    sort(B.begin(), B.end(), greater<int>());

    for (int i = 0; i < A.size(); i++) {
        sum = A[i] * B[i];
        answer += sum;
        sum = 0;
    }

    cout << answer << endl;
    return 0;
}

*/

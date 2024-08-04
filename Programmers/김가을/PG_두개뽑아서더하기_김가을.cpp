
#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;

vector<int> solution(vector<int> numbers) {
    vector<int> answer;
    int num = 0;

    for (int i = 0; i < numbers.size(); i++) {
        
        for (int j = i + 1; j < numbers.size(); j++) {
            num = numbers[i] + numbers[j];

            answer.push_back(num);
        }
    }

    sort(answer.begin(), answer.end());
    //unique : 벡터 중복되는 요소를 뒤 인덱스로 빼는 함수
    answer.erase(unique(answer.begin(), answer.end()), answer.end());

    return answer;
}


////////////////////////////
///////////C++코드///////////
///////////////////////////
/*

#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;


int main(int argc, char const* argv[])
{
    vector<int> numbers;
    numbers.push_back(2);
    numbers.push_back(1);
    numbers.push_back(3);
    numbers.push_back(4);
    numbers.push_back(1);
    vector<int> answer;
    int num = 0;

    for (int i = 0; i < numbers.size(); i++) {
        
        for (int j = i + 1; j < numbers.size(); j++) {
            num = numbers[i] + numbers[j];

            answer.push_back(num);
        }
    }

    sort(answer.begin(), answer.end());
    //unique : 벡터 중복되는 요소를 뒤 인덱스로 빼는 함수
    answer.erase(unique(answer.begin(), answer.end()), answer.end());

    for (int i = 0; i < answer.size(); i++) {
        cout << answer[i];
    }

    return 0;
}
*/

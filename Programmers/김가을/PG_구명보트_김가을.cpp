#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;

int solution(vector<int> people, int limit) {
    int answer = 0;
        //idx
    int start = 0, end = people.size() - 1;

    //asc sort
    sort(people.begin(), people.end());

     while(start <= end){
        if (people[start] + people[end] <= limit) {
            start++;
        }
        
        end--; answer++;
    }



    if (start == end) answer++;

    return answer;
}


////////////////////////
//////////C++풀이///////
///////////////////////

/*
#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;


int main(int argc, char const* argv[])
{
    //구명보트

    vector<int> people;
    people.push_back(70);
    people.push_back(80);
    people.push_back(50);

    int limit = 100;
    int answer = 0;
    
    //idx
    int start = 0, end = people.size() - 1;

    //asc sort
    sort(people.begin(), people.end());

    //가장 가벼운사람 + 가장 무거운사람 <= limit

    while(start <= end){
        if (people[start] + people[end] <= limit) {
            start++;
        }
        
        end--; answer++;
    }

    //만난 거.. 남는 사람 한 명
    if (start == end) answer++;

    cout << answer;

    return 0;
}
*/

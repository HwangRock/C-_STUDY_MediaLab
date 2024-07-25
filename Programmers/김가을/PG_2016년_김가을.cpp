#include <string>
#include <vector>

using namespace std;

string solution(int a, int b) {
    string answer = "";
    string day[] = { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU"};
	int month[] = { 31,29,31,30,31,30,31,31,30,31,30,31 };
	int sum = 0;
	for (int i = 0; i < a - 1; i++) { //그 전 달까지 일을 다 더함
		sum += month[i];
	}
	sum += b - 1; 
	answer = day[sum % 7];
    return answer;
}

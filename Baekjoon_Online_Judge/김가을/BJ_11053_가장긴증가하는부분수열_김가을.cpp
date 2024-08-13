#include <iostream>

using namespace std;

int n, num[1001], lis[1001], want;
//lis : i번째 수가 제일 끝에 있을 때 증가하는 부분수열의 길이 , want : 최대길이

int main(void) {
	//동적 계획법!

	ios::sync_with_stdio(false); cin.tie(NULL);
	cin >> n;

	for (int i = 1; i <= n; i++) {
		cin >> num[i];
	}

	for (int i = 1; i <= n; i++) {
		lis[i] = 1;
		for (int j = 1; j <= i; j++) {
			//자기 자신보다 작은 것이 있다면 증가
			if (num[j] < num[i]) lis[i] = max(lis[i], lis[j] + 1);
		}
	}

	for (int i = 1; i <= n; i++) {
		if (want < lis[i]) {
			want = lis[i];
		}
	}

	cout << want;

}

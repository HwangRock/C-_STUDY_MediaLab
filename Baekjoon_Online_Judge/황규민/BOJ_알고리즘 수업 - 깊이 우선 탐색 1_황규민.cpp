#include<iostream>
#include<vector>
#include<algorithm>

#define maxi 100001

using namespace std;

int n, m, r, seq = 1, sequence[maxi];
vector<int>graph[maxi];

void dfs(int start) {
	sequence[start] = seq;
	for (int i = 0; i < graph[start].size(); i++) {
		int next = graph[start][i];
		if (!sequence[next]) {
			seq++;
			dfs(next);
		}
	}
}

int main() {
	cin >> n >> m >> r;
	for (int i = 0; i < m; i++) {
		int a = 0, b = 0;
		cin >> a >> b;
		graph[a].push_back(b), graph[b].push_back(a);
	}
	for (int i = 1; i <= n; i++) {
		sort(graph[i].begin(), graph[i].end());
	}
	dfs(r);
	
	for (int i = 1; i <= n; i++) {
		cout << sequence[i] << "\n";
	}
}

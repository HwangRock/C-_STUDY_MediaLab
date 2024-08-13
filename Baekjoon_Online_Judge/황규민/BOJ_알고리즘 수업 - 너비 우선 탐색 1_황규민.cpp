#include<iostream>
#include<queue>
#include<vector>
#include<algorithm>

#define maxi 100001

using namespace std;

int n, m, r, seq = 1, sequence[maxi];
vector<int>graph[maxi];

void bfs(int start) {
	queue<int>q;
	q.push(start);
	sequence[start] = seq;
	while (!q.empty()) {
		int current = q.front();
		q.pop();
		for (int i = 0; i < graph[current].size(); i++) {
			int next = graph[current][i];
			if (!sequence[next]) {
				seq++;
				sequence[next] = seq;
				q.push(next);
			}
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
	sequence[r] = 1;
	bfs(r);
	
	for (int i = 1; i <= n; i++) {
		cout << sequence[i] << "\n";
	}
}

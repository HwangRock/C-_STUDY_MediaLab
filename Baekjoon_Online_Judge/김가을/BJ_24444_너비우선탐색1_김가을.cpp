#define _CRT_SECURE_NO_WARNINGS
#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

#include <queue>
#include <map>
#include <stdio.h>

using namespace std;

bool visited[100001] = { false, };
int order[100001]; //방문순서 저장

vector<int> graph[100001];
int count_ = 1; //방문순서 카운트


void bfs(int r) {
    queue<int> q;
    q.push(r);
    visited[r] = true;
    order[r] = count_; //현재 정점 방문순서 저장
    count_++;

    

    while (!q.empty()) {
        int a = q.front();
        q.pop();

        //현재 정점의 인접 정점 방문
        for (auto n : graph[a]) {
            if (!visited[n]) {
                visited[n] = true;
                order[n] = count_;
                count_++;
                q.push(n);
            }
        }
    }


}

int main(int argc, char const* argv[])
{
   // 백준 너비 우선 탐색 1
    int n, m, r;

    scanf("%d %d %d", &n, &m, &r); //메모리관리


    for (int i = 0; i < m; i++) {
        int x, y;
        scanf("%d %d", &x, &y);
        graph[x].push_back(y);
        graph[y].push_back(x);
    }
    
    for (int i = 1; i <= n; i++) {
        sort(graph[i].begin(), graph[i].end());
    }

    bfs(r);
    for (int i = 1; i <= n; i++) {
        printf("%d\n", order[i] == 0 ? 0 : order[i]); //방문 x : 0 출력
    }

    return 0;
}




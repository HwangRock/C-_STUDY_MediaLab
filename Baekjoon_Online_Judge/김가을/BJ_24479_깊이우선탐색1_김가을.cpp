#define _CRT_SECURE_NO_WARNINGS
#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

#include <map>
#include <stdio.h>

using namespace std;

bool visited[100006] = { false, };
int order[100006]; //방문순서 저장
vector<int> graph[100006];
int count_ = 1; //방문순서 카운트

void dfs(int r) {
    if (visited[r]) return;
    visited[r] = true;
    order[r] = count_; //현재 정점 방문순서 저장
    count_++;
    //printf("%d\n", r);

    sort(graph[r].begin(), graph[r].end());

    //인접 노드 사이즈만큼 탐색
    for (int i = 0; i < graph[r].size(); i++) {
        int a = graph[r][i];
        if (!visited[a]) {
            dfs(a); //재귀방문
        }
    }
}



int main(int argc, char const* argv[])
{
   //백준 - 깊이 우선 탐색 1
    //재귀함수나 스택으로 구현 
    int n, m, r; //정점 수, 간선 수, 시작 정점
    
    scanf("%d %d %d", &n, &m, &r); //메모리관리


    for (int i = 0; i < m; i++) {
        int x, y;
        scanf("%d %d", &x, &y);
        graph[x].push_back(y);
        graph[y].push_back(x);
    }


    dfs(r);
    for (int i = 1; i <= n; i++) {
        printf("%d\n", order[i] == 0 ? 0 : order[i]); //방문 x : 0 출력
    }
    

    return 0;
}

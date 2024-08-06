//BFS에 대한 부연설명
//https://blog.naver.com/hwang_rock/223364033766

#include <cstring>
#include <vector>
#include <iostream>
#include <queue>

using namespace std;

vector<pair<int, int>>destination(2);

int dx[4] = { -1,0,0,1 };
int dy[4] = { 0,1,-1,0 };
int visit[101][101];
int garo, sero;
vector<string> graph;

int bfs(int a, int b, int state) {
    queue<pair<pair<int, int>, int>>q;
    q.push({ {a,b},0 });
    bool able = false;
    int want = 0;
    visit[a][b] = 1;
    while (!q.empty()) {
        int y = q.front().first.first, x = q.front().first.second;
        int distance = q.front().second;
        q.pop();
        if (y == destination[state].first and x == destination[state].second) {
            able = true;
            want = distance;
            break;
        }
        for (int i = 0; i < 4; i++) {
            int ny = y + dy[i];
            int nx = x + dx[i];
            if (ny >= 0 and ny < sero and nx >= 0 and nx < garo and !visit[ny][nx]) {
                if (graph[ny][nx] == 'O' or graph[ny][nx] == 'L' or graph[ny][nx] == 'E' or graph[ny][nx] == 'S') {
                    q.push({ {ny,nx},distance + 1 });
                    visit[ny][nx] = 1;
                }
            }
        }
    }
    if (able) {
        return want;
    }
    else {
        return 0;
    }
}

int solution(vector<string> maps) {
    sero = maps.size();
    garo = maps[0].length();
    graph = maps;
    pair<int, int>start;
    for (int i = 0; i < sero; i++) {
        for (int j = 0; j < garo; j++) {
            char cur = maps[i][j];
            if (cur == 'S') {
                start = { i,j };
            }
            if (cur == 'L') {
                destination[0]={ i,j };
            }
            if (cur == 'E') {
                destination[1] = { i,j };
            }
        }
    }
    int path1 = bfs(start.first, start.second, 0);
    if (path1) {
        memset(visit, 0, sizeof(visit));
        int path2 = bfs(destination[0].first, destination[0].second, 1);
        if (path2) {
            return path1 + path2;
        }
        else {
            return -1;
        }
    }
    else {
        return -1;
    }
}

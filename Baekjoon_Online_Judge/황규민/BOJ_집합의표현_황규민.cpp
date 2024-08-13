#include<iostream>

using namespace std;

#define maxi 1000001

int n, m, parent[maxi];


//사용한 자료구조 : 유니온-파인드 자료구조
//자세한 설명 : https://blog.naver.com/hwang_rock/223489785120
int find(int a);
void merge(int a, int b);

int find(int a) {
    if (parent[a] < 0) {
        return a;
    }
    parent[a] = find(parent[a]);
    return parent[a];
}

void merge(int a, int b) {
    a = find(a);
    b = find(b);
    if (a == b) {
        return;
    }
    if (parent[a] >= parent[b]) {
        parent[b] += parent[a];
        parent[a] = b;
    }
    else {
        parent[a] += parent[b];
        parent[b] = a;
    }
}

int main() {
    ios::sync_with_stdio(false); cin.tie(NULL);
    cin >> n >> m;
    for (int i = 0; i <= n; i++) {
        parent[i] = -1;
    }
    for (int i = 0; i < m; i++) {
        int a = 0, b = 0, c = 0;
        cin >> a >> b >> c;
        if (!a) {
            merge(b, c);
        }
        else {
            int chk1 = find(b);
            int chk2 = find(c);
            if (chk1 == chk2) {
                cout << "YES" << "\n";
            }
            else {
                cout << "NO" << "\n";
            }
        }
    }
}

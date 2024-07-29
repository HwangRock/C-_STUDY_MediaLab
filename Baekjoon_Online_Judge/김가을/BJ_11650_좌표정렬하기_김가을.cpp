#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;

typedef struct st { //구조체
    int x; int y;
};

bool compare(st a, st b)
{
    if (a.x == b.x) {
        return a.y < b.y;
    }
    else {
        return a.x < b.x;
    }
}

int main(int argc, char const* argv[])
{
    int n, x, y;
    cin >> n;
    st ary[100000];

    for (int i = 0; i < n; i++) {
        cin >> ary[i].x >> ary[i].y;
    }
    
    sort(ary, ary + n, compare);
    
    for (int i = 0; i < n; i++) {
        cout << ary[i].x << " " << ary[i].y << "\n";
    }
    
    return 0;
}

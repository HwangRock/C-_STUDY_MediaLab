
#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;

int NoSelf(int a) {
    int sum = 0, n = 0, aa = a;
    while (a > 0) {
        n = a % 10;
        sum += n;
        a /= 10;
    }
    return aa + sum;
}

int main(int argc, char const* argv[])
{
    bool ary[10001] = { false };
    int n = 0;

    for (int i = 1; i < 10001; i++) {
        n = NoSelf(i);
        if (n < 10001) {
            ary[n] = true;
        }
    }

    for (int i = 1; i < 10001; i++) {
        if (ary[i] == false) cout << i << "\n";
    }
    
    return 0;
}

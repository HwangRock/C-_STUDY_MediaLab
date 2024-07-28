//
#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

int main(int argc, char const* argv[])
{
    //블랙잭
    int n, m;
    int sum = 0, res = 0;
    int v[100]; //벡터로 하니까 오류가 나서 배열로
    std::cin >> n >> m;

    for (int i = 0; i < n; i++) {
        std::cin >> v[i];
    }

    for (int i = 0; i < n - 2; i++) { //인덱스를 어케하지?.
        for (int j = i + 1; j < n - 1; j++) {
            for (int k = j + 1; k < n; k++) { //왜 j+1이 아닌 i+2를 넣으면 틀리지?
                sum = v[i] + v[j] + v[k];
                if (sum > res && sum <= m) { res = sum; } //갱신
            }
        }
    }
    std::cout << res;

    return 0;
}

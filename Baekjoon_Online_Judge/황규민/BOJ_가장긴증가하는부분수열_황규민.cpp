#include <iostream>

using namespace std;

#define maxi 1001

int n, num[maxi], lis[maxi], want;

int main(void){
    ios::sync_with_stdio(false);cin.tie(NULL);
    cin >> n;
    for (int i = 1; i <= n; i++) {
        cin >> num[i];
    }
    
    /////////////////////////////////////////////////////////
    //n이 10000이하이기 가능한 풀이. O(n^2)이므로 최적화가 필요함./
    ////////////////////////////////////////////////////////
    
    for (int i = 1; i <= n; i++) {
        lis[i] = 1; //자기자신을 나타냄.
        for (int j = 1; j <= i; j++) {
            if (num[j] < num[i]) {
                lis[i] = max(lis[i], lis[j] + 1); //자기자신보다 작은 것이 있다면 증가.
            }
        }
    }
    for (int i = 1; i <= n; i++) {
        if (want < lis[i]) {
            want = lis[i]; //최댓값을 찾아냄.
        }
    }
    cout << want;
}

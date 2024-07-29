#include <string>
#include <vector>

using namespace std;

vector<int> solution(int brown, int yellow) {
    vector<int> answer;
    
    
    int  w = 0, h = 0;
    bool able = false;

    for (w = 1; w < 2000000; w++) {
        //yellow = (w - 2) * (h - 2);
        //brown = 2 * (h + w - 2);
        for (h = 1; h <= w; h++) {
            if (((((w - 2) * (h - 2)) + (2 * (h + w - 2))) == w * h)
                && ((w - 2) * (h - 2)) == yellow && (2 * (h + w - 2)) == brown) {
                able = true;
                answer.push_back(w);
                answer.push_back(h);
                break;
            }
            if (able) break;
        }

    }

    
    
    return answer;
}

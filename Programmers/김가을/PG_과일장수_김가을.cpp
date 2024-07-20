//과일 장수

#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int solution(int k, int m, vector<int> score) {
    int answer = 0;
    
    sort(score.begin(), score.end(), greater<int>()); //내림차순 정렬
  
  //m만큼 묶으면 됨    
    for(int i = m - 1; i < score.size(); i += m){        
        answer += score[i] * m;
    }  
    
    return answer;
}

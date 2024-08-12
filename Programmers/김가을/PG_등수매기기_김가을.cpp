#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

#include <map>

using namespace std;

vector<int> solution(vector<vector<int>> score) {
    vector<int> answer;
    int a = 0;
    vector<int> avg, tmp;
    int rank = 1;
    //map : key, value 트리, 중복 허용하지 않음, 내림차순정렬 : map<int, int, greater>map1;
    map<int, int> map_;

    //각 인덱스별 평균 구하기
    for (int i = 0; i < score.size(); i++) {
        avg.push_back((score[i][0] + score[i][1])); //나누기 하면 오류 생겨서 생략
    }

    tmp = avg;

    sort(tmp.begin(), tmp.end(), greater<>());

    //map 이용해 중복 점수 처리, 최초로 발견된 점수에 등수 +1
    for (int i = 0; i < tmp.size(); i++) {
        //find : 특정 키가 맵에 있는지 찾고 존재하지 않으면 map_.end() 반환
        if ( map_.find(tmp[i]) == map_.end()) {
            //평균 점수에 대한 등수를 기록함
            
            //int a = 0;
            
            for(int j = i + 1; j < tmp.size(); j++){
                
                if(tmp[i] == tmp[j]){
                    a++;
                    
                }
            }
            
            map_[tmp[i]] = rank;
            rank += a;
            a = 0;
            rank++;
        }
            
        
    }

    for (int i = 0; i < tmp.size(); i++) {
        
        answer.push_back(map_[avg[i]]);
    }
    
    return answer;
}

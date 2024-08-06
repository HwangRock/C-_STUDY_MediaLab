
#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;

int solution(vector<vector<int>> board) {
    int answer = 0;
    
    //검사 인덱스
int dx[] = { -1, -1, -1, 0, 0, 1, 1, 1 };
int dy[] = { 1, 0, -1, -1, 1, -1, 0, 1 };

int width = board[0].size(), height = board.size();


for (int i = 0; i < height; i++) {
	for (int j = 0; j < width; j++) {
		if (board[i][j] == 1) //지뢰가 있음
		{
			for (int k = 0; k < 8; k++)//주변 8칸 검사
			{
				int y = i + dy[k];
				int x = j + dx[k];

				if (y >= 0 and x >= 0 and y < height and x < width and board[y][x] == 0 ) {
					board[y][x] = 2;
				}
			}
		}
	}
}

for (int i = 0; i < height; i++) {
	for (int j = 0; j < width; j++) {
		if (board[i][j] == 0) answer++;
	}
}
    
    return answer;
}




////////////////////////////////////
////////////C++코드/////////////////
///////////////////////////////////

/*
#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

using namespace std;

int main(int argc, char const* argv[])
{
	vector<vector<int>> board;
	board.push_back({ 1,1,1,1,1 });
	board.push_back({ 1,1,1,1,1 });
	board.push_back({ 1,1,1,1,1 });
	board.push_back({ 1,1,1,1,1 });
	board.push_back({ 1,1,1,1,1 });

	int answer = 0;

	//검사 인덱스
	int dx[] = { -1, -1, -1, 0, 0, 1, 1, 1 };
	int dy[] = { 1, 0, -1, -1, 1, -1, 0, 1 };

	int width = board[0].size(), height = board.size();
	

	for (int i = 0; i < height; i++) {
		for (int j = 0; j < width; j++) {
			if (board[i][j] == 1) //지뢰가 있음
			{
				for (int k = 0; k < 8; k++)//주변 8칸 검사
				{
					int y = i + dy[k];
					int x = j + dx[k];

					//board[y][x] == 0이 맨 앞에 있으면 오류 -> 순서 중요~
					if ( y >= 0 and x >= 0 and y < height and x < width and board[y][x] == 0) {
						board[y][x] = 2;
					}
				}
			}
		}
	}

	for (int i = 0; i < height; i++) {
		for (int j = 0; j < width; j++) {
			if (board[i][j] == 0) answer++;
		}
	}

	cout << answer;

	return 0;
}
*/

using System;

public class Solution
{
    public int solution(int[,] board)
    {
        int answer = 0;

        //좌표 이동을 위한 배열
        int[] dx = new int[8] {-1,-1,-1,0,0,1,1,1 };
        int[] dy = new int[8] {1,0,-1,-1,1,-1,0,1 };
        
      
        int sero = board.GetLength(0);
        int garo = board.GetLength(1);

        for (int i = 0; i < sero; i++)
        {
         for(int j=0;j<garo; j++)
            {
                if (board[i, j] == 1)
                {
                    for(int k = 0; k < 8; k++)
                    {
                        int y = i + dy[k];
                        int x = j + dx[k];
                        if(y>=0  && x>=0 && y<sero && x<garo && board[y, x] == 0)
                        {
                            board[y, x] = 2;
                        }
                    }
                }
            }   
        }
        for (int i = 0; i < sero; i++)
        {
            for (int j = 0; j < garo; j++)
            {
                if (board[i, j] == 0)
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}

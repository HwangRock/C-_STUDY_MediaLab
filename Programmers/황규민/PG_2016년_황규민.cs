public class Solution
{
    public string solution(int a,int b)
    {
        string answer = "";
        int day = 0;
        for(int i = 1; i < a; i++)
        {
            if (i == 2)
            {
                day += 29;
            }
            else if(i==4 || i==6 || i==9 || i == 11)
            {
                day += 30;
            }
            else
            {
                day += 31;
            }
        }
        day += b;
        int when = day % 7;
        switch (when)
        {
            case 0:
                answer = "THU";
                break;
            case 1:
                answer = "FRI";
                break;
            case 2:
                answer = "SAT";
                break;
            case 3:
                answer = "SUN";
                break;
            case 4:
                answer = "MON";
                break;
            case 5:
                answer = "TUE";
                break;
            case 6:
                answer = "WED";
                break;
        }
        
        return answer;
    }
}

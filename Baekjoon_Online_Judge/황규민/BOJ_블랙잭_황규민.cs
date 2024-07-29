string[] str1 = Console.ReadLine().Split();
int n = int.Parse(str1[0]);
int m = int.Parse(str1[1]);
string[] str2 = Console.ReadLine().Split();
int[] num = new int[n];
int maxi = 0;
for(int i = 0; i < n; i++)
{
    num[i]= int.Parse(str2[i]);
}
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        if (i == j)
        {
            continue;
        }
        for(int k = 0; k < n; k++)
        {
            if(k==i || k== j){
                continue;
            }
            int calcul = num[i] + num[j] + num[k];
            if (calcul>maxi && calcul<=m)
            {
                maxi = calcul;
            }
        }
    }
}
Console.WriteLine(maxi);

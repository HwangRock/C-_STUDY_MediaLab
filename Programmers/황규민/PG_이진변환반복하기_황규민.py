def solution(s):
    change = 0
    ans = []
    recur = 0

    while s != '1':
        cur = []
        recur += 1
        for i in s:
            if i == '0':
                s = s.replace(i, '')  # 0을 없앰.
                change += 1  # 0을 없앤 횟수

        fin = len(s) # 2진수로 만들 대상

        while fin > 0:  # 2진수로 바꾸는 과정
            cur.append(fin % 2)
            fin //= 2
        cur.reverse()  # 작은수부터 넣었으니 뒤집어줌

        number = ''.join(map(str, cur))  # cur의 정수 원소를 map 함수에서 str 함수를 이용해서 str로 변환. join을 이용해서 원소를 빈틈없이 합쳐서 문자열을 만듦.
        s = number

    ans.append(recur)
    ans.append(change)

    return ans

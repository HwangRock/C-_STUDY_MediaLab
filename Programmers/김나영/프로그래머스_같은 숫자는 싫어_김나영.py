//문제 언어 선택 중 C#이 없는 관계로 Python으로 진행함
def solution(arr):
    answer = []
    answer.append(arr[0])
    for i in range(1,len(arr)) :
        if arr[i] != arr[i-1]:
            answer.append(arr[i])
    return answer

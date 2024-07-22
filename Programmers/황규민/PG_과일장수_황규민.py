def solution(k, m, score):
    answer = 0
    score = sorted(score, reverse=True) #내림차순 정렬하는 코드
    iter = 0
    for i in score:
        iter += 1
        if iter == m:
            answer += i * m
            iter = 0
    
    return answer

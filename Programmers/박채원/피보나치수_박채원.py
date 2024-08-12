def solution(n):
    if n == 0:
        return 0
    elif n == 1:
        return 1
    
    # 초기값 설정
    fibo = [0] * (n + 1)
    fibo[1] = 1
    
    # DP로 피보나치 수열 계산 - (동적프로그래밍)
    for i in range(2, n + 1):
        fibo[i] = (fibo[i - 1] + fibo[i - 2]) % 1234567
    
    return fibo[n]

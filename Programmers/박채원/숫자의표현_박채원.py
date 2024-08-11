def solution(n):
    count = 0
    
    # 연속된 숫자의 시작 숫자
    for start in range(1, n + 1):
        total = 0
        num = start
        
        # 연속된 숫자의 합을 구하는 과정
        while total < n:
            total += num
            num += 1
            
        # total이 n과 같으면 카운트 증가
        if total == n:
            count += 1
    
    return count

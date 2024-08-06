def solution(n, s):
    # s가 n보다 작은 경우
    if s < n:
        return [-1]

    # 몫과 나머지 계산
    quotient = s // n
    remainder = s % n

    # 기본 배열을 몫으로 채운다
    best_set = [quotient] * n

    # 나머지를 분배하여 각 원소에 1씩 추가
    for i in range(remainder):
        best_set[i] += 1

    # 결과는 오름차순으로 정렬되어 있음
    best_set.sort()
    return best_set

def main():
    # 사용자로부터 입력 받기
    n = int(input(""))
    s = int(input(""))
    
    # solution 함수 호출
    result = solution(n, s)
    
    # 결과 출력
    print(result)

# 메인 함수 실행
if __name__ == "__main__":
    main()

def solution(arr1, arr2):
    # arr1의 행과 열, arr2의 행과 열 구하기
    rows1, cols1 = len(arr1), len(arr1[0])
    rows2, cols2 = len(arr2), len(arr2[0])

    # 결과 행렬 초기화 (arr1의 행 수 x arr2의 열 수)
    result = [[0] * cols2 for _ in range(rows1)]

    # 행렬 곱셈 수행
    for i in range(rows1):
        for j in range(cols2):
            for k in range(cols1):  # arr1의 열 == arr2의 행
                result[i][j] += arr1[i][k] * arr2[k][j]

    return result

# 예시 입력
arr1 = [
    [1, 2],
    [3, 4]
]

arr2 = [
    [5, 6],
    [7, 8]
]

# 함수 호출 및 결과 출력
result = solution(arr1, arr2)
for row in result:
    print(row)

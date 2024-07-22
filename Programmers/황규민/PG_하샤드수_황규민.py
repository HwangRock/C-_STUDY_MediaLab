def solution(s):
    s = str(s)
    num = int(s)
    hap = 0
    for i in s:
        cur = int(i)
        hap += cur

    if num % hap == 0:
        return True
    else:
        return False

def solution(s):
    answer = ''
    
    ary = list(map(int, s.split(' ')))         
    ary.sort()                                  
    answer = str(ary[0]) + " " + str(ary[-1])
    
    return answer

def solution(quiz):
    answer = []
    
    for i in quiz:
        l, r = i.split('=')
        l = l.split()

        if l[1] == '+':
            if int(l[0]) + int(l[2]) == int(r):
                answer.append('O')
            else:
                 answer.append('X')
        elif l[1] == '-':
            if int(l[0]) - int(l[2]) == int(r):
                answer.append('O')
            else:
                 answer.append('X')

        elif l[1] == '/':
            if int(l[0]) / int(l[2]) == int(r):
                answer.append('O')
            else:
                 answer.append('X')

        elif l[1] == '*':
            if int(l[0]) * int(l[2]) == int(r):
                answer.append('O')
            else:
                 answer.append('X')
    return answer

sum_pos=0
sum_neg=0
for i in range (0,10):
    print (i)
    n=int(input("input int: "))
    if n >=0:
        sum_pos+=n
    if n<0:
        sum_neg+=n
print('sum of all positive intergers is: ',sum_pos)
print('sum of all negative integers is: ',sum_neg)
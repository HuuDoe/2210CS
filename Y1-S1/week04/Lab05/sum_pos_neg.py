pos_sum = 0
neg_sum = 0

for i in range(10):
    num = int(input(f'Enter the {i + 1} integer: '))
    if num > 0:
        pos_sum += num
    else:
        neg_sum += num

print('The sum of positive integers:', pos_sum)
print('The sum of negative integers:', neg_sum)
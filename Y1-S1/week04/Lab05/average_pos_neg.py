pos_sum = 0
neg_sum = 0

n_pos = 0
n_neg = 0

for i in range(10):
    num = int(input(f'Enter the {i + 1} integer: '))
    if num > 0:
        pos_sum += num
        n_pos += 1
    elif num < 0:
        neg_sum += num
        n_neg += 1

if n_pos:
    print('The sum of positive integers:', pos_sum)
    avg_pos = pos_sum / n_pos
    print('The average of all positive integers:', avg_pos)
else:
    print('There is no positive numbers')

if n_neg:
    print('The sum of negative integers:', neg_sum)
    avg_neg = neg_sum / n_neg
    print('The average of all negative integers:', avg_neg)
else:
    print('There is no negative number')
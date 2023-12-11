from sympy import n_order


cell = '*'

width = int(input('Enter the number of column(s): '))
height = int(input('Enter the number of row(s): '))


for _ in range(width):
    print('')
    for _ in range(height):
        print(cell, end=' ')
print(' ')
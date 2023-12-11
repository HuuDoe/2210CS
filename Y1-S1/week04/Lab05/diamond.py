width = int(input("Enter the width of diamond's edge: "))

while width < 2 or width > 40:
    print("The width of the diamond's edge must be between 2 and 40!")
    width = int(input("Enter the width of diamond's edge: "))

for i in range(1, width + 1):
    print(' ' * (width - i), '* ' * i, sep='')

for i in range(width - 1, 0, -1):
    for j in range(width - i):
        print(' ', end='')
    print('* ' * i)

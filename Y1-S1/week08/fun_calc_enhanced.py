menu = '''1. Add 
2. Subtract 
3. Multiply 
4. Divide 
5. Remainder 
'''

def add(num_1, num_2):
    result = num_1 + num_2
    print(f'{num_1} + {num_2} = {result}')
    
def subtract(num_1, num_2):
    result = num_1 - num_2
    print(f'{num_1} - {num_2} = {result}')

def multiply(num_1, num_2):
    result = num_1 * num_2
    print(f'{num_1} * {num_2} = {result}')

def divide(num_1, num_2):
    try:
        result = num_1 / num_2
        print(f'{num_1} / {num_2} = {round(result, 3)}')
    except ZeroDivisionError:
        print('Divisor must not be zero!')

def remainder(num_1, num_2):
    try:
        result = num_1 % num_2
        print(f'{num_1} % {num_2} = {result}')
    except ZeroDivisionError:
        print('Divisor must not be zero!')

def menu_input():
    print(menu)
    choice = int(input('Your choice: ').strip())
    while choice not in range(1, 6):
        choice = int(input('Your choice: ').strip())
    return choice

def main():
    while True:
        try:
            num_1 = int(input("Enter the first integer: "))
            num_2 = int(input("Enter the second integer: "))
            break
        except ValueError:
            print('Make sure both inputs are integers!')
    
    choice = menu_input()
    
    if choice == 1:
        add(num_1, num_2)
    elif choice == 2:
        subtract(num_1, num_2)
    elif choice == 3:
        multiply(num_1, num_2)
    elif choice == 4:
        divide(num_1, num_2)
    else:
        remainder(num_1, num_2)

main()
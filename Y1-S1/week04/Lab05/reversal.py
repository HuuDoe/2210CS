while True:
    integer = input('Enter an integer of at least 2 digits or -1 to quit: ').strip()
    while len(integer) > 1 and integer[0] == '0':
        integer = integer[1:]
    if 1 < len(integer) < 11:
        if integer[0] == '-' and integer[1:].isnumeric():
            print('Program end.')
            break
        elif integer.isnumeric():
            reversed_int = int(integer[::-1])
            print('Your integer reversed is:', reversed_int)
        else:
            print('Your input is invalid, please try again.')
    else:
        print('Your input is invalid, please try again.')

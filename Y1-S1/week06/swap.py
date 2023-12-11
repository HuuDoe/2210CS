def swap(int_list):
    return [int_list[1], int_list[0]]

def print_int_list(int_list):
    for num in int_list:
        print(num, end=' ')

def main():
    int_list = []
    for num in input('Enter two integers: ').split(' '):
        int_list.append(int(num))

    swaped_int_list = swap(int_list)
    print('You entered:', end=' ')
    print_int_list(int_list)
    print('\nYour entries swaped:', end=' ')
    print_int_list(swaped_int_list)

main()
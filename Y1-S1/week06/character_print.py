def character_print(char, print_times):
    for _ in range(print_times):
        print(char)

def user_input():
    char = ''
    while len(char) != 1:
        char = input('Enter a character: ')
    print_times = int(input('Enter the times character be printed: '))

    return ((char, print_times))

def main():
    char, print_times = user_input()
    character_print(char, print_times)

main()

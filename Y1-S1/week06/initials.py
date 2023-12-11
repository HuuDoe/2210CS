def main():
    full_name = input('Enter your full name: ').lstrip().rstrip()

    name_components = full_name.upper().split(' ')
    first_letters = [word[0] for word in name_components]
    initials = '.'.join(first_letters)

    print('Your initials is', initials)

main()
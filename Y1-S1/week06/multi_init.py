import re
def user_input():
    user_inp = input('User input: ').lstrip().rstrip()
    names = re.findall('".*?"', user_inp)
    return list(map(lambda name: name.replace('"', ''), names))

def generate_initial(name: str):
    initial = ''
    name = name.lstrip().rstrip()
    for i in range(len(name) - 1):
        if i == 0 or name[i - 1] == ' ' or name[i] == '-' or name[i - 1] == '-':
            if len(initial) and name[i - 1] == ' ':
                initial += '.'
            initial += name[i].upper()
    return initial

def main():
    names = user_input()
    print('Initials output:', end=' ')
    for name in names:
        print(generate_initial(name))

main()
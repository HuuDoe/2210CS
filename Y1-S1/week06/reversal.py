def recursive_reverse(string, id):
    if id >= 0:
        return string[id] + recursive_reverse(string, id - 1)
    else:
        return ''
        
def main():
    input_str = input('Enter a string to be reversed: ')
    print(recursive_reverse(input_str, len(input_str) - 1))

main()
rainbow_color = ['red', 'orange', 'yellow', 'green', 'blue', 'indigo', 'violet']

def main():
    input_id = int(input('Your choice: '))
    if input_id == -1:
        print('Program end.')
    else:
        if input_id in range(1, 8):
          print(f'The color No.{input_id} of the rainbow is: {rainbow_color[input_id - 1]}')
        else:
            print('ERROR: The input integer should ranges from 1 to 7!')
        main()

print('Enter an integer from 1 to 7 shows the order of a color of rainbow or -1 to terminate program.')
main()
password = 'pasw'

input_pasw = input('Please enter the password: ').lower()

if input_pasw == password:
    print('Input password matched. Welcome!')
else: 
    print('Incorrect password!')
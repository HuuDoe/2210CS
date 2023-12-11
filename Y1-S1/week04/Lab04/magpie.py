prompts = ['', 'One for sorrow', 'Two for joy', 'Three for a girl', 'Four for a boy',
    'Five for silver', 'Six for gold', 'Seven for a secret never to be told'
]

input_num = int(input('Please enter an integer between 1 and 7 inclusive: '))

if 1 <= input_num <= 7:
    print(prompts[input_num])
else:
    print('Not a permitted number')
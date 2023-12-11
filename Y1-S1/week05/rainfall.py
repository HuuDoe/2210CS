histo_char = 'x'
months = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec']

def user_input() -> list:
    rainfall = []
    for month in months:
        while True:
            try:
                rainfall.append(int(input(f'Enter rainfall for {month}: ')))
                break
            except Exception:
                pass
    return rainfall

def print_column(data: list):
    top_value = max(data)
    while top_value > 0:
        for value in data:
            if value >= top_value:
                print('', histo_char, end='\t')
            else:
                print('', end='\t')
        print('')
        top_value -= 1

def main():
    rainfall = user_input()
    print('')
    print_column(rainfall)
    print('\t'.join(months))

main()

def get_input():
    while True:
        print('Enter the rating for restaurant (from 1 to 5):', end=' ')
        try:
            rating = int(input().strip())
            if rating == -1 or rating in range(1, 6):
                return rating
            else:
                print('Please enter rating ranging from 1 to 5.')
        except ValueError:
            print('ValueError: Please provide numerical input.')
            return 0

def print_rate(rate_info):
    print('No. Rate', 'Vote', sep='\t')
    for id, rate in enumerate(rate_info):
        if id:
            print(id, rate, sep='\t\t')

def main():
    rate_info = [0 for _ in range(0, 6)]
    current_rating = 0 
    total_rate = 0
    rate_times = 0
    
    while True:
        current_rating = get_input()
        if current_rating != -1:
            rate_times += 1
            total_rate += current_rating
            rate_info[current_rating] += 1
        else:
            break
    
    print('-' * 20)
    print_rate(rate_info)
    average_rate = total_rate / rate_times
    
    print('-' * 20)
    print('Average rate:', average_rate)


main()
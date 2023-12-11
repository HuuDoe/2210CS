import random

valid_cards_value = list(range(1, 14))

cards = {
    1: 'Ace',
    11: 'Jack',
    12: 'Queen',
    13: 'King'
}

first_generated_num = random.choice(valid_cards_value)
valid_cards_value.remove(first_generated_num)

print('Value randomly generated:', first_generated_num)

print('Card value:', end=' ')

if 2 <= first_generated_num <= 10:
    print(first_generated_num)
else:
    print(cards[first_generated_num])

user_guess = input('The next card will be higher or lower? ').lower()

second_generated_num = random.choice(valid_cards_value)

print('Next card value:', end=' ')

if 2 <= first_generated_num <= 10:
    print(first_generated_num)
else:
    print(cards[first_generated_num])


if user_guess == 'lower':
    if first_generated_num > second_generated_num:
        print('You win!')
    else: 
        print('You lose!')
else:
    if first_generated_num < second_generated_num:
        print('You win!')
    else: 
        print('You lose!')
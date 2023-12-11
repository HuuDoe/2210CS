import random

ROCK = 'rock'
PAPER = 'paper'
SCISSOR = 'scissor'

valid_choices = [ROCK, SCISSOR, PAPER]
winning_cond = 3

computer_wins = 0
user_wins = 0
final_winner = ''

def play():
    global computer_wins, user_wins

    user_choice = input('Enter your selection: ').lower()
    while user_choice not in valid_choices:
        print(f"Please enter a valid choice ({', '.join(valid_choices)})!")
        user_choice = input('Enter your selection: ').lower()
    
    user_choice_id = valid_choices.index(user_choice)
    computer_choice_id = random.randint(0, len(valid_choices) - 1)

    print('You chose:', user_choice.capitalize())
    print('Computer chose:', valid_choices[computer_choice_id].capitalize())

    if user_choice_id == computer_choice_id:
        print('It was a draw')
    else:
        if user_choice_id == (computer_choice_id + 1) % len(valid_choices):
            print('Congratulations, you win')
            user_wins += 1
        else:
            print('Computer won')
            computer_wins += 1

while computer_wins < winning_cond and user_wins < winning_cond:
    play()
    print('You need:', winning_cond - user_wins, 'to complete the game.')
    print('The computer needs:', winning_cond - computer_wins, 'to complete the game.')
    print('*' * 10)

if computer_wins == winning_cond:
    final_winner = 'computer'
else:
    final_winner = 'user'

print(f'Commiserations the {final_winner} won . . .')
print('Game over . . .')

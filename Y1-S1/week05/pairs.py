import random

original_card = ['J', 'Q', 'K', 'A'] 
display_matrix = [ [ '*' for _ in range(4) ] for _ in range(4) ]

card_matrix = []

total_cards = 16
n_selections = 0

def print_matrix(mat):
    print(' ', end=' ')
    for i in range(len(mat)):
        print(i, end=' ')
    print(' ')
    for id, row in enumerate(mat):
        print(id, end=' ')
        for cell in row:
            print(cell, end=' ') 
        print('')

def extract_pair_input():
    inp = []
    for pos in input().rstrip().split(' '):
        inp.append(int(pos))
    return inp

def user_guesses():

    print('Enter first card\'s positions:', end=' ')
    first_cards = extract_pair_input()

    print('Enter second card\'s positions:', end=' ')
    second_cards = extract_pair_input()

    return ((first_cards, second_cards))

def evaluate_guess(first_cards, second_cards):
    global total_cards
    x1, y1 = first_cards
    x2, y2 = second_cards

    if x1 == x2 and y1 == y2:
        print('Please enter unique positions for each guess!')
    else:
        try:
            if display_matrix[x1][y2] == 'X' or display_matrix[x2][y2] == 'X':
                print('Card at one of the input position has been used.')
            elif card_matrix[x1][y1] == card_matrix[x2][y2]:
                display_matrix[x1][y1] = 'X'
                display_matrix[x2][y2] = 'X'
                total_cards -= 2
                print('Cards at the positions are matched')
            else:
                print('Cards at the positions are not matched')
        except IndexError:
            print('Please enter proper position indexes!')

def main():
    global card_matrix, display_matrix
    global original_card, n_selections, total_cards

    for _ in range(4):
        random.shuffle(original_card)
        card_matrix.append(list(original_card))

    print_matrix(display_matrix)

    first_cards, second_cards = user_guesses()

    evaluate_guess(first_cards, second_cards)

    n_selections += 1
    if total_cards:
        print('-' * 10)
        main()
    else:
        print('Congrats! All the cards are matched.')
        print('Number of selections made:', n_selections)

main()
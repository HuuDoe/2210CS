import random

board_size = 5
n_hit_ship = 0

ship_cells = []
missed_cells = []
hit_cells = []

def generate_ship_pos():
    first_pos = [random.randint(1, board_size), random.randint(1, board_size)]
    second_pos = []
    next_pos_axis = random.randint(0, 1)
    if next_pos_axis:
        if first_pos[1] < board_size:
            second_pos = [first_pos[0], first_pos[1] + 1]
        else:
            second_pos = [first_pos[0], first_pos[1] - 1]
    else:
        if first_pos[0] < board_size:
            second_pos = [first_pos[0] + 1, first_pos[1]]
        else:
            second_pos = [first_pos[0] - 1, first_pos[1]]
    ship_cells.append(first_pos)
    ship_cells.append(second_pos)

def print_board():
    print(' ', end=' ')
    for i in range(board_size):
        print(f' {i + 1}', end='  ')
    print('')

    for i in range(1, board_size + 1):
        print(i, end=' ')
        for j in range(1, board_size + 1):
            pos = [i, j]
            cell = ' '
            if pos in missed_cells:
                cell = 'M'
            elif pos in hit_cells:
                cell = 'H'
            print(f'[{cell}]', end=' ')
        print('')

def ask_for_shot():
    shot_pos = []
    print('Enter a shot (r c):', end=' ')
    for str_pos in input().lstrip().rstrip().split(' '):
        shot_pos.append(int(str_pos))
    return shot_pos

def evaluate_shot(shot_pos):
    global hit_cells, missed_cells
    x, y = shot_pos
    if x > 5 or y > 5:
        print('Invalid coordination!')
    elif shot_pos in missed_cells or shot_pos in hit_cells:
        print('You have shot in this position before!')
    else:
        if shot_pos in ship_cells:
            hit_cells.append(shot_pos)
            print_board()
            if len(hit_cells) < len(ship_cells):
                print('Well done you hit!')
            else:
                print('Glug, glug, glug... you won.')
        else:
            missed_cells.append(shot_pos)
            print_board()
            print('Sorry you missed!')

def main():
    generate_ship_pos()
    print(ship_cells)
    while len(hit_cells) < len(ship_cells):
        shot_pos = ask_for_shot()
        evaluate_shot(shot_pos)

main()
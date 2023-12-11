import random

dice_1 = 0
dice_2 = -1
dice_times = 1

print(f'Dice #', 'Dice 1', 'Dice 2', sep='\t')

while dice_1 != dice_2:
    dice_1 = random.randint(1, 6)
    dice_2 = random.randint(1, 6)
    print(dice_times, dice_1, dice_2, sep='\t')
    dice_times += 1

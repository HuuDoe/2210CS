from random import randint
from time import sleep

while True:
    print('rolling dice...')
    sleep(1)
    dice2=randint(1,6)
    dice1=randint(1,6)
    print(dice1,dice2)
    if dice1==dice2:
        print ('matched')
        break
    else:
        sleep(1)
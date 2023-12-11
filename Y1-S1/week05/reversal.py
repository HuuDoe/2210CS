input_words = input("Enter a string to be reversed: ").split(' ')

for word in input_words:
    print(word[::-1], end=' ')


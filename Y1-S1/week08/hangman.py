def get_keyword():
    while True:
        keyword = input('Word to be guessed: ').lstrip().rstrip()
        if keyword.isalpha():
            return keyword.lower()
        else:
            print('Enter a word only!')


def letter_guess(keyword: list, dash_word: list):
    letter = ''
    while not letter.isalpha() or len(letter) != 1:
        letter = input('Letter guessed: ').strip().lower()
    if letter in dash_word:
        print(f"The letter '{letter}' has been revealed!")
    elif letter in keyword:
        for id, char in enumerate(keyword):
            if letter == char:
                dash_word[id] = letter
    return dash_word

def main():
    
    keyword = list(get_keyword())
    dash_word = list('-' * len(keyword))

    while dash_word != keyword:
        print('Display:', ''.join(dash_word))
        dash_word = letter_guess(keyword, dash_word)
    print('Display:', ''.join(dash_word))
    print('Program ended.')
main()
import json

def read_file() -> dict:
    with open('char_classes.json') as txt:
        return json.loads(txt.read())

def main():
    dict_data = read_file()
    headers = ['Strength', 'Intelligence', 'Wisdom', 'Dexterity', 'Constitution']
    keys = list(dict_data.keys())

    print('Class', '\t\t', '\t\t'.join(headers), sep='')

    for key in keys:

        if len(key) > 7:
            print(key.capitalize(), end='\t')
        else:
            print(key.capitalize(), end='\t\t')

        for value in list(dict_data[key].values()):
            print(value, end='\t\t\t')

        print('')
main()
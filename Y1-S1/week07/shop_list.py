def user_input():
    items = {}
    for _  in range(5):
        item_info = input().rstrip().lstrip()
        info_split = item_info.split(' ')
        item_name = ' '.join(info_split[0:len(info_split) - 1])
        items[item_name] = float(info_split[-1])
    return items

def sort_items_dict(item_info):
    item_name = item_info.keys()
    
    price_sorted = sorted(item_info.values())[::-1]
    sorted_item_info = {}
    
    for price in price_sorted:
        for key in item_name:
            if item_info[key] == price:
                sorted_item_info[key] = price
    return sorted_item_info

def main():
    item_info = user_input()
    sorted_items_dict = sort_items_dict(item_info)
    for item, price in sorted_items_dict.items():
        print("{0:.2f}".format(item), price)

main()
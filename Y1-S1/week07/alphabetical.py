def user_input():
    arr_str = []
    for i in range(5):
        entered_str = ''
        while not(entered_str.strip()):
            print(f'Enter the string No.{i + 1}:', end=' ')
            entered_str = input()
        arr_str.append(entered_str)
    return arr_str

def split(arr):
    if len(arr) <= 1:
        return [arr, []]
    else:
        piviot = len(arr) // 2
        return [arr[:piviot], arr[piviot:]]

def merge(arr_1, arr_2):
    merged_arr = []
    i = 0
    j = 0
    while i < len(arr_1) and j < len(arr_2):
        if arr_1[i] < arr_2[j]:
            merged_arr.append(arr_1[i])
            i += 1
        else:
            merged_arr.append(arr_2[j])
            j += 1
    while i < len(arr_1):
        merged_arr.append(arr_1[i])
        i += 1
    while j < len(arr_2):
        merged_arr.append(arr_2[j])
        j += 1
    return merged_arr 

def merge_sort(arr):
    first_part, second_part = split(arr)
    if len(first_part) > 1:
        first_part = merge_sort(first_part)
    if len(second_part) > 1:
        second_part = merge_sort(second_part)
    return merge(first_part, second_part)

def main():
    input_arr = user_input()
    sorted_arr = merge_sort(input_arr)
    print('The sorted list:', ', '.join(sorted_arr))

main()
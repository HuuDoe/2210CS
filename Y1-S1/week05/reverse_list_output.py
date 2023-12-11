def reverse_list(arr):
    reversed_arr = []
    for i in range(-1, -(len(arr)) - 1, -1):
        reversed_arr.append(arr[i])
    return reversed_arr

def main():
    required_len = 5
    input_arr = []
    for i in range(required_len):
        input_arr.append(int(input(f"Input the integer No.{i + 1}: ")))
    result_list = reverse_list(input_arr)

    print('The reversed list is: ', end='')
    for num in result_list:
        print(num, end=' ')

main()

print('\n')

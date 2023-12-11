def insertion_sort(array: list):
    arr = array
    for i in range(1, len(arr)):
        value = arr[i]
        j = i - 1
        while j >= 0 and arr[j] < value:
            arr[j + 1] = arr[j]
            j -= 1
        arr[j + 1] = value
    return arr

def main():
    arr = [1, 25, 8, 4, 100, 60, 7, 8, 4, 3]

    print('Original array:', arr)
    print('Sorted array:', insertion_sort(arr))

main()
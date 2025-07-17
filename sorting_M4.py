import time
import random

# -------------------------
# Bubble Sort Implementation

def bubble_sort(arr):
    n = len(arr)
    for i in range(n):
        # Optimization: stop if no swaps
        swapped = False
        for j in range(0, n - i - 1):
            if arr[j] > arr[j + 1]:
                arr[j], arr[j + 1] = arr[j + 1], arr[j]
                swapped = True
        if not swapped:
            break
    return arr

# -------------------------
# Quick Sort Implementation
# -------------------------
def quick_sort(arr):
    if len(arr) <= 1:
        return arr
    else:
        pivot = arr[0]
        left = [x for x in arr[1:] if x <= pivot]
        right = [x for x in arr[1:] if x > pivot]
        return quick_sort(left) + [pivot] + quick_sort(right)

# -------------------------
# Dataset Generator
# -------------------------
def generate_data(size):
    return [random.randint(1, 100000) for _ in range(size)]

# -------------------------
# Time Measurement Utility
# -------------------------
def measure_time(sort_func, data):
    data_copy = data.copy()  # Avoid sorting the same reference
    start = time.time()
    sort_func(data_copy)
    end = time.time()
    return end - start

# -------------------------
# Run Experiments
# -------------------------
if __name__ == "__main__":
    sizes = {
        "Small": 10,
        "Medium": 1000,
        "Large": 10000
    }

    for label, size in sizes.items():
        print(f"\n--- {label} Dataset ({size} items) ---")
        dataset = generate_data(size)

        bubble_time = measure_time(bubble_sort, dataset)
        quick_time = measure_time(quick_sort, dataset)

        print(f"Bubble Sort Time: {bubble_time:.6f} seconds")
        print(f"Quick Sort Time:  {quick_time:.6f} seconds")

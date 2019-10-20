import math
import os
import random
import re
import sys

# Complete the balancedSums function below.
def balancedSums(arr):
    left = 0
    right = 0
    length = len(arr)
    for i in range(length):
        left = 0
        right = 0

        for j in range(i):
            left += arr[j]

        for k in range(i + 1, length):
            right += arr[k]

        if left == right:
            return 'YES'

    return 'NO'


input = open('TestCase3_oneLine.txt', 'r')

for line in input.readlines():
        arr = list(map(int, line.rstrip().split()))
        result = balancedSums(arr)
        print(result)

input.close()


import math
import os
import random
import re
import sys


# Complete the balancedSums function below.
def balancedSums(arr):
    left = 0
    sum = 0
    length = len(arr)

    for i in range(length):
        sum += arr[i]

    for j in range(length):
        sum -= arr[j]

        if left == sum:
            return 'YES'

        left += arr[j]

    return 'NO'


# input = open('TestCase3_oneLine.txt', 'r')

# for line in input.readlines():
#        arr = list(map(int, line.rstrip().split()))
#        result = balancedSums(arr)
#        print(result)

# input.close()

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    T = int(input().strip())

    for T_itr in range(T):
        n = int(input().strip())

        arr = list(map(int, input().rstrip().split()))

        result = balancedSums(arr)

        fptr.write(result + '\n')

    fptr.close()

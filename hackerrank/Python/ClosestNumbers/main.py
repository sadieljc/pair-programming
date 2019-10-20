import math
import os
import random
import re
import sys

# Complete the closestNumbers function below.
def closestNumbers(arr):
    results = []
    difference = 0
    smallestDifference = sys.maxsize

    for index in range(0, len(arr)-1):
        difference = (arr[index + 1] - arr[index]).__abs__()

        # difference is smaller than smallest
        if difference < smallestDifference:
            smallestDifference = difference
            results.clear()
            results.append(arr[index])
            results.append(arr[index+1])
        elif difference == smallestDifference:
            results.append(arr[index])
            results.append(arr[index + 1])

    return results


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    result = closestNumbers(arr)

    fptr.write(' '.join(map(str, result)))
    fptr.write('\n')

    fptr.close()
import math
import os
import random
import re
import sys


def birthdayCakeCandles(ar):
    tallest = max(ar)
    result = 0

    for n in ar:
        if n == tallest:
            result += 1

    return result


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    ar_count = int(input())

    ar = list(map(int, input().rstrip().split()))

    result = birthdayCakeCandles(ar)

    fptr.write(str(result) + '\n')

    fptr.close()

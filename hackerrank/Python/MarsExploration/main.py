import math
import os
import random
import re
import sys

# Complete the marsExploration function below.
def compareToSOS(s):
    counter = 0
    expected = 'SOS'

    for i in range(0, len(s)):
        if s[i] != expected[i]:
            counter += 1

    return  counter


def marsExploration(s):
    trios = [s[i:i+3] for i in range(0, len(s), 3)]
    result = 0

    for t in trios:
        result += compareToSOS(t)

    return  result


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    result = marsExploration(s)

    fptr.write(str(result) + '\n')

    fptr.close()

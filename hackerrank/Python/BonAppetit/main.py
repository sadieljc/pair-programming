import math
import os
import random
import re
import sys

# Complete the bonAppetit function below.
def bonAppetit(bill, anaDidntLike, amountCharged):
    amountForSharedItems = 0

    index = 0
    for item in bill:
        if index != anaDidntLike:
            amountForSharedItems += item

        index += 1

    evenSplittedBillForShareItems = int(amountForSharedItems / 2)

    if evenSplittedBillForShareItems == amountCharged:
        return "Bon Appetit"
    else:
        return amountCharged - evenSplittedBillForShareItems


if __name__ == '__main__':
    nk = input().rstrip().split()

    n = int(nk[0])

    k = int(nk[1])

    bill = list(map(int, input().rstrip().split()))

    b = int(input().strip())

    bonAppetit(bill, k, b)

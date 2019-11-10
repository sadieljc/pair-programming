#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the gameOfStones function below.
class Player(object):
    stones = 0

    def __init__(self, stones):
        self.stones = stones


    def RemoveStones(self, n):
        # I cannot play
        if n - 2 < 0:
            self.stones = n - 2
            return False
        # I win
        elif n - 2 == 0 or n - 3 == 0 or n - 5 == 0:
            self.stones = 0
            return True
        # I remove stones so I win
        else:
            possible_moves = [2, 3, 5]
            currentStones = self.stones
            for move in possible_moves:
                if not self.RemoveStones(n - move):
                    self.stones = currentStones - move
                    return True


def gameOfStones(n):
    # a player can take only 2, 3 or 5
    player1 = Player(n)

    stone_removal_result = player1.RemoveStones(n)

    if not stone_removal_result:
        return 'Second'
    elif stone_removal_result and (player1.stones == 0 or player1.stones == 1):
        return 'First'


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    t = int(input())

    for t_itr in range(t):
        n = int(input())

        result = gameOfStones(n)

        fptr.write(result + '\n')

    fptr.close()
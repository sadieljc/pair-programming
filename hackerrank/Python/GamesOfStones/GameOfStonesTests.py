import unittest
from main import gameOfStones


class GameOfStonesTests(unittest.TestCase):

    def test1(self):
        case = 1

        result = gameOfStones(case)

        self.assertEqual('Second', result)

    def test2(self):
        case = 2

        result = gameOfStones(case)

        self.assertEqual('First', result)

    def test3(self):
        case = 3

        result = gameOfStones(case)

        self.assertEqual('First', result)

    def test4(self):
        case = 4

        result = gameOfStones(case)

        self.assertEqual('First', result)

    def test5(self):
        case = 5

        result = gameOfStones(case)

        self.assertEqual('First', result)

    def test6(self):
        case = 6

        result = gameOfStones(case)

        self.assertEqual('First', result)

    def test7(self):
        case = 7

        result = gameOfStones(case)

        self.assertEqual('Second', result)

    def test8(self):
        case = 10

        result = gameOfStones(case)

        self.assertEqual('First', result)
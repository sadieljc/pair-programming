import unittest
from main import closestNumbers


class ClosestNumbersTests(unittest.TestCase):

    def test1(self):
        numbers = [-20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854]

        numbers.sort()
        result = closestNumbers(numbers)

        self.assertEqual(-20, result[0])
        self.assertEqual(30, result[1])

    def test2(self):
        numbers = [-20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854, -520, -470]

        numbers.sort()
        result = closestNumbers(numbers)

        self.assertEqual(-520, result[0])
        self.assertEqual(-470, result[1])
        self.assertEqual(-20, result[2])
        self.assertEqual(30, result[3])

    def test3(self):
        numbers = [5, 4, 3, 2]

        numbers.sort()
        result = closestNumbers(numbers)

        self.assertEqual(2, result[0])
        self.assertEqual(3, result[1])
        self.assertEqual(3, result[2])
        self.assertEqual(4, result[3])
        self.assertEqual(4, result[4])
        self.assertEqual(5, result[5])
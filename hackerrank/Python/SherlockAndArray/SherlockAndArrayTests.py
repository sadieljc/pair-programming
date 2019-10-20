import unittest
from main import balancedSums


class SherlockAndArrayTests(unittest.TestCase):

    def test1(self):
        numbers = [1, 2, 3]

        result = balancedSums(numbers)

        self.assertEqual('NO', result)


    def test2(self):
        numbers = [1, 2, 3, 3]

        result = balancedSums(numbers)

        self.assertEqual('YES', result)
import unittest
import main

class BirthdayCandelTests(unittest.TestCase):

    def test1(self):
        candles = [3, 2, 1, 3]

        result = main.birthdayCakeCandles(candles)

        # assert
        self.assertEqual(2, result)

    def test2(self):
        candles = [18,90,90,13,90,75,90,8,90,43]

        result = main.birthdayCakeCandles(candles)

        self.assertEqual(5, result)
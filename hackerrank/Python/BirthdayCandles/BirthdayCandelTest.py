import unittest
import main

class BirthdayCandelTests(unittest.TestCase):

    """
    def test_upper(self):
        self.assertEqual('foo'.upper(), 'FOO')

    def test_isupper(self):
        self.assertTrue('FOO'.isupper())
        self.assertFalse('Foo'.isupper())

    def test_split(self):
        s = 'hello world'
        self.assertEqual(s.split(), ['hello', 'world'])
        # check that s.split fails when the separator is not a string
        with self.assertRaises(TypeError):
            s.split(2)
    """

    def test1(self):
        candles = [3, 2, 1, 3]

        result = main.birthdayCakeCandles(candles)

        # assert
        self.assertEqual(2, result)

    def test2(self):
        candles = [18,90,90,13,90,75,90,8,90,43]

        result = main.birthdayCakeCandles(candles)

        self.assertEqual(5, result)
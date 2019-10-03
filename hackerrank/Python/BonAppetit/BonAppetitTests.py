import unittest
from main import bonAppetit


class BonAppetitTests(unittest.TestCase):

    def test_ReturnAmountToRefund_When_NotEvenlySplitted(self):
        bill = [3, 10, 2, 9]
        anaDidntLike = 1
        amountCharged = 12

        result = bonAppetit(bill, anaDidntLike, amountCharged)

        self.assertEqual(5, result)

    def test_ReturnBonAppetit_When_EvenlySplitted(self):
        bill = [3,10,2,9]
        anaDidnLike = 1
        amountCharged = 7

        result = bonAppetit(bill, anaDidnLike, amountCharged)

        self.assertEqual("Bon Appetit", result)
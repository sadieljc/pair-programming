import unittest
from main import marsExploration


class MarsExplorationTests(unittest.TestCase):

    def test1(self):
        receivedSignal = 'SOSSPSSQSSOR'

        result = marsExploration(receivedSignal)

        self.assertEqual(3, result)


    def test2(self):
        receivedSignal = 'SOSSOT'

        result = marsExploration(receivedSignal)

        self.assertEqual(1, result)


    def test3(self):
        receivedSignal = 'SOSSOSSOS'

        result = marsExploration(receivedSignal)

        self.assertEqual(0, result)
using System.Collections.Generic;

namespace Core
{
    public class BonAppetit
    {
        public string Evaluate(List<int> bill, int anaDidntLike, int amountCharged)
        {
            var amountForSharedItems = 0;

            for (var i = 0; i < bill.Count; i++)
            {
                if (i != anaDidntLike)
                    amountForSharedItems += bill[i];
            }

            var evenSplittedBillForSharedItems = amountForSharedItems / 2;

            return evenSplittedBillForSharedItems == amountCharged 
                ? "Bon Appetit" 
                : (amountCharged - evenSplittedBillForSharedItems).ToString();
        }
    }
}
﻿//Interface
public interface ICheckout
{
    void Print();
    int CalculatePrice(int name);
    int CalculatePriceA(int itemA, int priceA);
    public int CalculateTotalPriceWithDiscountA(int itemA, int priceA);
}
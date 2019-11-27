﻿namespace ChainOfResponsibility
{
    public class Banknote : IBanknote
    {
        public Banknote(CurrencyType currency, int value)
        {
            Currency = currency;
            Value = value;
        }

        public CurrencyType Currency { get; }
        public int Value { get; }
    }
}
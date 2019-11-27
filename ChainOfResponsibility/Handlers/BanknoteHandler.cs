using System;
using System.Collections.Generic;

namespace ChainOfResponsibility.Handlers
{
    public abstract class BanknoteHandler
    {
        private readonly BanknoteHandler _nextHandler;

        protected abstract CurrencyType CurrencyType { get; }
        protected abstract int Value { get; }

        protected BanknoteHandler(BanknoteHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public virtual IList<IBanknote> CacheOut(int value, CurrencyType type, IList<IBanknote> banknotes)
        {
            if (_nextHandler != null) return _nextHandler.CacheOut(value, type, banknotes);
            if (value == 0)
                return banknotes;
            throw new Exception("не валидная сумма");

        }
    }
}
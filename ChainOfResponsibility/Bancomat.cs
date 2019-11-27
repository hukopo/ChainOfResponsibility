﻿ using System.Collections.Generic;
  using ChainOfResponsibility.Handlers;

  namespace ChainOfResponsibility
{
    public class Bancomat
    {
        private readonly BanknoteHandler _handler;

        public Bancomat()
        {
            _handler = new TenRubleHandler(null);
            _handler = new TenDollarHandler(_handler);
            _handler = new FiftyDollarHandler(_handler);
            _handler = new HundredDollarHandler(_handler);
        }
        
        public IList<IBanknote> CashOut(int value, CurrencyType type)
        {
            return _handler.CacheOut(value, type, new List<IBanknote>());
        } 
    }
}

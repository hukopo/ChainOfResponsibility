using System.Collections.Generic;

namespace ChainOfResponsibility.Handlers
{
    public abstract class BanknoteHandlerBase : BanknoteHandler
    {
        public override IList<IBanknote> CacheOut(int value, CurrencyType type, IList<IBanknote> banknotes)
        {
            if (type != CurrencyType || value < Value) 
                return base.CacheOut(value, type, banknotes);
            
            var count = value / Value;
            value -= count * Value;

            for (var i = 0; i < count; i++)
            {
                banknotes.Add(new Banknote(CurrencyType, Value));
            }

            return base.CacheOut(value, type, banknotes);
        }

        protected BanknoteHandlerBase(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }
    }
}
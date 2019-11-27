namespace ChainOfResponsibility.Handlers
{
    public class OneEurHandler : BanknoteHandlerBase
    {
        protected override CurrencyType CurrencyType => CurrencyType.Eur;
        protected override int Value => 1;

        public OneEurHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}
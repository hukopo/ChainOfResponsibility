namespace ChainOfResponsibility.Handlers
{
    public class FiftyDollarHandler : BanknoteHandlerBase
    {
        protected override CurrencyType CurrencyType => CurrencyType.Dollar;
        protected override int Value => 50;

        public FiftyDollarHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}